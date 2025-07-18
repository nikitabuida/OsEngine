﻿using System.Collections.Generic;

namespace OsEngine.Market.Servers.GateIo.GateIoSpot.Entities
{
    public class ApiEntities
    {
        public string id { get; set; }
        public string create_time { get; set; }
        public string create_time_ms { get; set; }
        public string currency_pair { get; set; }
        public string side { get; set; }
        public string amount { get; set; }
        public string price { get; set; }
    }

    public class CurrencyPair
    {
        public string id;
        public string Base;
        public string quote;
        public string fee;
        public string min_base_amount;
        public string min_quote_amount;
        public string amount_precision;
        public string precision;
        public string trade_status;
        public string sell_start;
        public string buy_start;
    }

    public class GetCurrencyVolumeResponse
    {
        public string currency;
        public string available;
        public string locked;
    }

    public class MessageDepths
    {
        public long t;
        public long lastUpdateId;
        public string s;
        public List<string[]> bids;
        public List<string[]> asks;
    }

    public class MessagePublicTrades
    {
        public string id;
        public string create_time;
        public string create_time_ms;
        public string side;
        public string currency_pair;
        public string amount;
        public string price;
    }

    public class MessageUserTrade
    {
        public string id;
        public string user_id;
        public string order_id;
        public string currency_pair;
        public string create_time;
        public string create_time_ms;
        public string side;
        public string amount;
        public string role;
        public string price;
        public string fee;
        public string fee_currency;
        public string point_fee;
        public string gt_fee;
        public string text;
        public string amend_text;
        public string biz_info;
        public string sequence_id;
    }

    public class OrderResponse
    {
        public string currency_pair;
        public string total;
        public List<MessageUserOrder> orders;
    }

    public class MessageUserOrder
    {
        public string id;
        public string text;
        public string create_time;
        public string update_time;
        public string currency_pair;
        public string type;
        public string status;
        public string account;
        public string side;
        public string amount;
        public string price;
        public string iceberg;
        public string time_in_force;
        public string left;
        public string filled_total;
        public string fill_price;
        public string filled_amount;
        public string avg_deal_price;
        public string fee;
        public string fee_currency;
        public string point_fee;
        public string gt_fee;
        public string gt_discount;
        public string gt_maker_fee;
        public string gt_taker_fee;
        public string rebated_fee;
        public string rebated_fee_currency;
        public string create_time_ms;
        public string update_time_ms;
        public string user;
        public string Event;
        public string stp_id;
        public string stp_act;
        public string finish_as;
        public string biz_info;
        public string amend_text;
    }

    public class TickerItem
    {
        public string currency_pair { get; set; }
        public string last { get; set; }
        public string lowest_ask { get; set; }
        public string highest_bid { get; set; }
        public string change_percentage { get; set; }
        public string base_volume { get; set; }
        public string quote_volume { get; set; }
        public string high_24h { get; set; }
        public string low_24h { get; set; }
    }
}
