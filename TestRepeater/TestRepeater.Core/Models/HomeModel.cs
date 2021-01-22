using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestRepeater.Core.Models
{
    public class HomeModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Status status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Server server { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataH data { get; set; }
    }

    public class DataH
    {
        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<BannerItem> banner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<GridItem> grid { get; set; }

        public ObservableCollection<GridPluginsItem> grid_plugins { get; set; }
    }

    public class GridItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// 
        /// </summary>
        private string _grid_id;
        public string grid_id
        {
            get { return _grid_id; }
            set { Set(ref _grid_id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _sequence_number;
        public string sequence_number
        {
            get { return _sequence_number; }
            set { Set(ref _sequence_number, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _type;
        public string type
        {
            get { return _type; }
            set { Set(ref _type, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private string _style;
        public string style
        {
            get { return _style; }
            set { Set(ref _style, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _data_type;
        public string data_type
        {
            get { return _data_type; }
            set { Set(ref _data_type, value); }
        }
        /// <summary>
        /// 最新更新
        /// </summary>
        public string _name;
        public string name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }
        /// <summary>
        /// 最新更新
        /// </summary>
        public string _description;
        public string description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _background_color;
        public string background_color
        {
            get { return _background_color; }
            set { Set(ref _background_color, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _cover_image_url;
        public string cover_image_url
        {
            get { return _cover_image_url; }
            set { Set(ref _cover_image_url, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _home_logo_switch;
        public string home_logo_switch
        {
            get { return _home_logo_switch; }
            set { Set(ref _home_logo_switch, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _home_logo_image_uri;
        public string home_logo_image_uri
        {
            get { return _home_logo_image_uri; }
            set { Set(ref _home_logo_image_uri, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _home_logo_category;
        public string home_logo_category
        {
            get { return _home_logo_category; }
            set { Set(ref _home_logo_category, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _home_logo_category_name;
        public string home_logo_category_name
        {
            get { return _home_logo_category_name; }
            set { Set(ref _home_logo_category_name, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _show_all_image_uri;
        public string show_all_image_uri
        {
            get { return _show_all_image_uri; }
            set { Set(ref _show_all_image_uri, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _show_all_image2_uri;
        public string show_all_image2_uri
        {
            get { return _show_all_image2_uri; }
            set { Set(ref _show_all_image2_uri, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string _show_all_background_color;
        public string show_all_background_color
        {
            get { return _show_all_background_color; }
            set { Set(ref _show_all_background_color, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<ProductItem> _product;
        public ObservableCollection<ProductItem> product
        {
            get { return _product; }
            set { Set(ref _product, value); }
        }
    }

    public class ProductItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #region Custom Added
        public string _type;
        public string type
        {
            get { return _type; }
            set { Set(ref _type, value); }
        }
        public string _style;
        public string style
        {
            get { return _style; }
            set { Set(ref _style, value); }
        }
        public string _data_type;
        public string data_type
        {
            get { return _data_type; }
            set { Set(ref _data_type, value); }
        }
        public string _background;
        public string background
        {
            get { return _background; }
            set { Set(ref _background, value); }
        }
        public string _cp_name;
        public string cp_name
        {
            get { return _cp_name; }
            set { Set(ref _cp_name, value); }
        }
        public string _item_type;
        public string item_type
        {
            get { return _item_type; }
            set { Set(ref _item_type, value); }
        }
        public string _product_free_time;
        public string product_free_time
        {
            get { return _product_free_time; }
            set { Set(ref _product_free_time, value); }
        }
        public string _product_id;
        public string product_id
        {
            get { return _product_id; }
            set { Set(ref _product_id, value); }
        }
        public string _product_number;
        public string product_number
        {
            get { return _product_number; }
            set { Set(ref _product_number, value); }
        }
        public string _series_cover_image_url;
        public string series_cover_image_url
        {
            get { return _series_cover_image_url; }
            set { Set(ref _series_cover_image_url, value); }
        }
        public string _series_description;
        public string series_description
        {
            get { return _series_description; }
            set { Set(ref _series_description, value); }
        }
        public int _watched_percent;
        public int watched_percent
        {
            get { return _watched_percent; }
            set { Set(ref _watched_percent, value); }
        }
        public int _watched_seconds;
        public int watched_seconds
        {
            get { return _watched_seconds; }
            set { Set(ref _watched_seconds, value); }
        }
        //category id
        public string _home_logo_category;
        public string home_logo_category
        {
            get { return _home_logo_category; }
            set { Set(ref _home_logo_category, value); }
        }
        public string _home_logo_switch;
        public string home_logo_switch
        {
            get { return _home_logo_switch; }
            set { Set(ref _home_logo_switch, value); }
        }
        #endregion

        ///The following is api returned 
        /// <summary>
        /// 
        /// </summary>
        public string _title;
        public string title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _sequence_number;
        public string sequence_number
        {
            get { return _sequence_number; }
            set { Set(ref _sequence_number, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _title_background_color;
        public string title_background_color
        {
            get { return _title_background_color; }
            set { Set(ref _title_background_color, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _use_series_title;
        public string use_series_title
        {
            get { return _use_series_title; }
            set { Set(ref _use_series_title, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _id;
        public string id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _series_id;
        public string series_id
        {
            get { return _series_id; }
            set { Set(ref _series_id, value); }
        }
        /// <summary>
        /// 德久，很久不见了
        /// </summary>
        public string _synopsis;
        public string synopsis
        {
            get { return _synopsis; }
            set { Set(ref _synopsis, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _number;
        public string number
        {
            get { return _number; }
            set { Set(ref _number, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _allow_download;
        public string allow_download
        {
            get { return _allow_download; }
            set { Set(ref _allow_download, value); }
        }
        /// <summary>
        /// int type maybe small for this field, use long instead
        /// </summary>
        public long _free_time;
        public long free_time
        {
            get { return _free_time; }
            set { Set(ref _free_time, value); }
        }
        /// <summary>
        /// 特别勤务监督官赵昌风
        /// </summary>
        private string _series_name;
        public string series_name
        {
            get { return _series_name; }
            set { Set(ref _series_name, value); }
        }
        /// <summary>
        /// 韩剧
        /// </summary>
        private string _series_category_name;
        public string series_category_name
        {
            get { return _series_category_name; }
            set { Set(ref _series_category_name, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string series_category_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private string _cover_image_url;
        public string cover_image_url
        {
            get { return _cover_image_url; }
            set { Set(ref _cover_image_url, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _focus_id;
        public string focus_id
        {
            get { return _focus_id; }
            set { Set(ref _focus_id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _focus_name;
        public string focus_name
        {
            get { return _focus_name; }
            set { Set(ref _focus_name, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _focus_start_section;
        public string focus_start_section
        {
            get { return _focus_start_section; }
            set { Set(ref _focus_start_section, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _focus_time_duration;
        public string focus_time_duration
        {
            get { return _focus_time_duration; }
            set { Set(ref _focus_time_duration, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _series_image_url;
        public string series_image_url
        {
            get { return _series_image_url; }
            set { Set(ref _series_image_url, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public int _is_movie;
        public int is_movie
        {
            get { return _is_movie; }
            set { Set(ref _is_movie, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _product_image_url;
        public string product_image_url
        {
            get { return _product_image_url; }
            set { Set(ref _product_image_url, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public int _is_parental_lock_limited;
        public int is_parental_lock_limited
        {
            get { return _is_parental_lock_limited; }
            set { Set(ref _is_parental_lock_limited, value); }
        }
        public int? _user_level;
        public int? user_level
        {
            get { return _user_level; }
            set { Set(ref _user_level, value); }
        }
        public long _offline_time;
        public long offline_time
        {
            get { return _offline_time; }
            set { Set(ref _offline_time, value); }
        }
        public string _poster_logo_url;
        public string poster_logo_url
        {
            get { return _poster_logo_url; }
            set { Set(ref _poster_logo_url, value); }
        }
        public string _source_flag;
        public string source_flag
        {
            get { return _source_flag; }
            set { Set(ref _source_flag, value); }
        }
        public string _allow_tv;
        public string allow_tv
        {
            get { return _allow_tv; }
            set { Set(ref _allow_tv, value); }
        }
    }

    public class BannerItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string sequence_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string banner_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string release_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_navigation_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_click_url { get; set; }
        /// <summary>
        /// 独家追播
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title_background_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_ad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string series_id { get; set; }
        /// <summary>
        /// 各位国民
        /// </summary>
        public string series_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> series_update_cycle { get; set; }
        /// <summary>
        /// 韩剧
        /// </summary>
        public string series_category_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string series_category_id { get; set; }
        /// <summary>
        /// 反击
        /// </summary>
        public string product_synopsis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allow_download { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_schedule_start_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_schedule_end_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long product_free_time { get; set; }
        public long premium_time { get; set; }
        public long is_free_premium_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long is_parental_lock_limited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_cover_image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string product_image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string series_image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_movie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? user_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string series_update_cycle_description { get; set; }

        public string offline_time { get; set; }
        public long free_time { get; set; }
        public string poster_logo_url { get; set; }
        public string source_flag { get; set; }
        public string allow_tv { get; set; }
    }

    public class GridPluginsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string grid_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sequence_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string style { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string data_type { get; set; }
        /// <summary>
        /// 您可能會喜歡
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 您可能會喜歡
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string background_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cover_image_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string home_logo_switch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string home_logo_image_uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string home_logo_category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string home_logo_category_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show_all_image_uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show_all_image2_uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show_all_background_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ProductYMAL> product { get; set; }
    }

}
