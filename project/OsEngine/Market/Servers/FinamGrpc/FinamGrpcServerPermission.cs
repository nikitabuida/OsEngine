/*
 *Your rights to use the code are governed by this license https://github.com/AlexWan/OsEngine/blob/master/LICENSE
 *Ваши права на использование кода регулируются данной лицензией http://o-s-a.net/doc/license_simple_engine.pdf
*/

namespace OsEngine.Market.Servers.FinamGrpc
{
    public class FinamGrpcServerPermission : IServerPermission
    {
        public ServerType ServerType
        {
            get { return ServerType.FinamGrpc; }
        }

        #region DataFeedPermissions

        public bool DataFeedTf1SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf2SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf5SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf10SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf15SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf20SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf30SecondCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTfTickCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTfMarketDepthCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf1MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf2MinuteCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf5MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf10MinuteCanLoad
        {
            get { return false; }
        }

        public bool DataFeedTf15MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf30MinuteCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf1HourCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf2HourCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTf4HourCanLoad
        {
            get { return true; }
        }

        public bool DataFeedTfDayCanLoad
        {
            get { return true; }
        }

        #endregion

        #region Trade permission

        public bool MarketOrdersIsSupport
        {
            get { return true; }
        }

        public int WaitTimeSecondsAfterFirstStartToSendOrders
        {
            get { return 60; }
        }

        public bool IsCanChangeOrderPrice
        {
            get { return false; }
        }

        public bool UseStandardCandlesStarter
        {
            get { return true; }
        }

        public bool IsUseLotToCalculateProfit
        {
            get { return true; }
        }

        public TimeFramePermission TradeTimeFramePermission
        {
            get { return _tradeTimeFramePermission; }
        }
        private TimeFramePermission _tradeTimeFramePermission
            = new TimeFramePermission()
            {
                TimeFrameSec1IsOn = false,
                TimeFrameSec2IsOn = false,
                TimeFrameSec5IsOn = false,
                TimeFrameSec10IsOn = false,
                TimeFrameSec15IsOn = false,
                TimeFrameSec20IsOn = false,
                TimeFrameSec30IsOn = false,
                TimeFrameMin1IsOn = true,
                TimeFrameMin2IsOn = false,
                TimeFrameMin3IsOn = false,
                TimeFrameMin5IsOn = true,
                TimeFrameMin10IsOn = false,
                TimeFrameMin15IsOn = true,
                TimeFrameMin20IsOn = false,
                TimeFrameMin30IsOn = true,
                TimeFrameMin45IsOn = false,
                TimeFrameHour1IsOn = true,
                TimeFrameHour2IsOn = true,
                TimeFrameHour4IsOn = true,
                TimeFrameDayIsOn = true
            };

        public bool ManuallyClosePositionOnBoard_IsOn
        {
            get { return true; }
        }

        public string[] ManuallyClosePositionOnBoard_ValuesForTrimmingName
        {
            get { return null; }
        }

        public string[] ManuallyClosePositionOnBoard_ExceptionPositionNames
        {
            get
            {
                string[] values = new string[]
                {
                    "rub",
                    "usd",
                    "eur",
                    "hkd"
                };

                return values;
            }
        }

        public bool CanQueryOrdersAfterReconnect
        {
            get { return true; }
        }

        public bool CanQueryOrderStatus
        {
            get { return true; }
        }

        #endregion

        #region Other Permissions

        public bool IsNewsServer
        {
            get { return false; }
        }

        public bool IsSupports_CheckDataFeedLogic
        {
            get { return true; }
        }

        public string[] CheckDataFeedLogic_ExceptionSecuritiesClass
        {
            get { return null; }
        }

        public int CheckDataFeedLogic_NoDataMinutesToDisconnect
        {
            get { return 10; }
        }

        public bool IsSupports_MultipleInstances
        {
            get { return true; }
        }

        public bool IsSupports_ProxyFor_MultipleInstances
        {
            get { return true; }
        }

        #endregion
    }
} 