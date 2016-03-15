using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EveCacheParser;
namespace CacheParser
{
    //Method call cache parse 
    namespace MethodCall
    {
        // Class for market order 
        class MarketOrder
        {
            public MarketOrder(IDictionary<object, object> order)
            {
                keys = order.Keys.ToList();
                keysCount = order.Keys.Count;
                //values = order.Values.ToList();
                price =(decimal)(double)order[keys[0]];
                volRemaining = (double)order[keys[1]];
                orderID = (long)order[keys[2]];
                issueDate = (long)order[keys[3]];
                typeID = (int)order[keys[4]];
                volEntered = (int)order[keys[5]];
                minVolume = (int)order[keys[6]];
                stationID = (int)order[keys[7]];
                regionID = (int)order[keys[8]];
                solarSystemID = (int)order[keys[9]];
                jumps = (int)order[keys[10]];
                range = (short)order[keys[11]];
                duration = (short)order[keys[12]];
                bid = (bool)order[keys[13]];
            }

            internal int keysCount { get; private set; }
            internal List<object> keys { get; private set; }
            //internal List<object> values { get; private set; }
            internal decimal price { get; private set; }

            internal double volRemaining { get; private set; }

            internal long orderID { get; private set; }

            internal long issueDate { get; private set; }

            internal int typeID { get; private set; }

            internal int volEntered { get; private set; }

            internal int minVolume { get; private set; }

            internal int stationID { get; private set; }

            internal int regionID { get; private set; }

            internal int solarSystemID { get; private set; }

            internal int jumps { get; private set; }

            internal short range { get; private set; }

            internal short duration { get; private set; }

            internal bool bid { get; private set; }
        }

        //Class for price history
        class PriceHistory
        {
            public PriceHistory(IDictionary<object, object> entry)
            {
                HistoryDate = (long)entry["historyDate"];
                LowPrice = (decimal)(double)entry["lowPrice"];
                HighPrice = (decimal)(double)entry["highPrice"];
                AveragePrice = (decimal)(double)entry["avgPrice"];
                Volume = (long)entry["volume"];
                Orders = (int)entry["orders"];
            }

            internal long HistoryDate { get; private set; }

            internal decimal LowPrice { get; private set; }

            internal decimal HighPrice { get; private set; }

            internal decimal AveragePrice { get; private set; }

            internal long Volume { get; private set; }

            internal int Orders { get; private set; }
        }

        class ParseMethodCall
        {
            //Parse file info function
           internal static string ParseCall(string method)
            {
                //Get cache file folder
                Parser.SetCachedFilesFolders("CachedMethodCalls");
                //Filter selected methodcall
                Parser.SetIncludeMethodsFilter(method);
                //Get cached files
                var cachedfiles = Parser.GetMachoNetCachedFiles();
                string strbuf = "";
                strbuf+= method+" get "+cachedfiles.Count().ToString()+" files."+Environment.NewLine;
                int count = 0;
                foreach (var cachefile in cachedfiles)
                {
                    strbuf += "Parsing file "+count.ToString() +" >"+ cachefile.Name + Environment.NewLine;
                    var result = Parser.Parse(cachefile);                  
                    var keys = (List<object>)((Tuple<object>)result.Key).Item1;
                    ParseObject(keys,ref strbuf);
                    var val = (Dictionary<object, object>)result.Value;
                    ParseObject(val,ref strbuf);
                }
                return strbuf;
            }

           internal static void ParseObject(Object obj,ref string logFile)
            {
                Type typeObj = obj.GetType();
                if (typeObj == typeof(Dictionary<object, object>))
                {
                    logFile+=Environment.NewLine;
                    foreach (var kvp in (Dictionary<object, object>)obj)
                    {
                        ParseObject(kvp.Key,ref  logFile);
                        //strbuf += ">";
                        ParseObject(kvp.Value,ref  logFile);
                    }
                }
                else
                    if (typeObj == typeof(List<object>))
                {
                    foreach (var eletmp in (List<object>)obj)
                    {
                        ParseObject(eletmp,ref  logFile);
                    }
                    logFile+=Environment.NewLine;

                }
                else
                if (typeObj == typeof(Tuple<object>))
                {
                    ParseObject(((Tuple<object>)obj).Item1,ref  logFile);
                }
                else
                {
                    logFile+=obj.ToString() + " ";
                }
            }

            //Parse GetOrders cache
           internal static List<MarketOrder> ParseOrders()
            {
                Parser.SetCachedFilesFolders("CachedMethodCalls");
                Parser.SetIncludeMethodsFilter("GetOrders");
                var cachedfiles = Parser.GetMachoNetCachedFiles();

                List<MarketOrder> marketOrders = new List<MarketOrder>();

                foreach (var cachedfile in cachedfiles)
                {
                    //Parse sigle order file
                    var result = Parser.Parse(cachedfile);

                    //Parse key info
                    //var keys = (List<object>)((Tuple<object>)result.Key).Item1;
                    //long regionID = (long)keys[2]; // regionID
                    //short typeID = (short)keys[3]; // typeID

                    //Parse value info.
                    //order info stored in lret dictionary list.
                    var ordersval = (List<object>)((Dictionary<object, object>)result.Value)["lret"];

                    //Parse order to list                   
                    foreach (var ordertmp in ordersval)
                    {
                        foreach (var orderd in (List<object>)ordertmp)
                        {
                                marketOrders.Add(new MarketOrder((Dictionary<object, object>)orderd));
                        }
                    }
                }

                return marketOrders;
                }

            //Parse "GetOldPriceHistory", "GetNewPriceHistory"
            static void ParsePriceHistory()
            {
                Parser.SetCachedFilesFolders("CachedMethodCalls");
                Parser.SetIncludeMethodsFilter("GetOrders");
                var cachedfiles = Parser.GetMachoNetCachedFiles();
                foreach (var cachedfile in cachedfiles)
                {
                    //Parse sigle order file
                    var result = Parser.Parse(cachedfile);

                    //Parse key info
                    var keys = (List<object>)((Tuple<object>)result.Key).Item1;
                    //long regionID = (long)keys[2]; // regionID
                    //short typeID = (short)keys[3]; // typeID

                    //Parse value info.
                    //order info stored in lret dictionary list.
                    var val = (List<object>)((Dictionary<object, object>)result.Value)["lret"];
                    var orders = val.Cast<List<object>>().SelectMany(obj => obj.Cast<Dictionary<object, object>>(), (obj, order) => new MarketOrder(order)).ToList();
                    var sellOrders = orders.Where(order => !order.bid).ToList();
                    var buyOrders = orders.Where(order => order.bid).ToList();
                }
            }
        }

    }
      
    }

