using System.Numerics;

namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public string bitcoins = "0";
        public string _plus_click = "1";
        public string _plus_auto = "0";

        public string slot_buy_count_1 = "0";
        public string slot_buy_count_2 = "0";
        public string slot_buy_count_3 = "0";
        public string slot_buy_count_4 = "0";
        public string slot_buy_count_5 = "0";
        public string slot_buy_count_6 = "0";
        public string slot_buy_count_7 = "0";
        public string slot_buy_count_8 = "0";
        public string slot_buy_count_9 = "0";
        public string slot_buy_count_10 = "0";
        public string slot_buy_count_11 = "0";
        public string slot_buy_count_12 = "0";
        public string slot_buy_count_13 = "0";
        public string slot_buy_count_14 = "0";
        public string slot_buy_count_15 = "0";

        public string slot_price_1 = "300";
        public string slot_price_2 = "1000";
        public string slot_price_3 = "2500";
        public string slot_price_4 = "7500";
        public string slot_price_6 = "15000";
        public string slot_price_7 = "85000";
        public string slot_price_8 = "150000";
        public string slot_price_9 = "350000";
        public string slot_price_10 = "850000";
        public string slot_price_11 = "1400000";
        public string slot_price_12 = "3250000";
        public string slot_price_13 = "7500000";
        public string slot_price_14 = "15000000";
        public string slot_price_15 = "17500000";
        public int current_comp = 1;
        public float currentProgress = 0f;
        public bool isBuyBtnShow = false;
        public int ad_showen = 0;

        public bool is_sounds_changed = false;
        public float sfx = 1;
        public float music = 1;

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива
        }
    }
}
