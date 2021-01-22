namespace TestRepeater.Helpers.Home
{
    public class HomeCardTextHelper
    {
        //http://confluence.ottuat.com:8090/pages/viewpage.action?pageId=15237164
        public static string FirstLineCardText(string type, string data_type,
            string number, int is_movie, string use_series_title,
            string synopsis, string series_name, string focus_name, string series_category_name)
        {
            switch (type)
            {
                case "1":
                    {
                        if(data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return synopsis;
                            else if (use_series_title == "1")
                                return series_name;
                        }
                    }
                    break;
                case "2":
                    {
                        if(data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return synopsis;
                            else if (use_series_title == "1")
                                return series_name;
                        }
                        else if(data_type == "2")
                        {
                            if (is_movie.ToString() == "0")
                                return focus_name;
                            else if (is_movie.ToString() == "1")
                                return focus_name;
                        }
                    }
                    break;
                case "3":
                    {
                        if(data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return synopsis;
                            else if (use_series_title == "1")
                                return series_name;
                        }
                        else if (data_type == "1" && is_movie.ToString() == "1")
                            return series_name;
                    }
                    break;
                case "4":
                    {
                        if (data_type == "1" && is_movie.ToString() == "1")
                            return series_name;
                    }
                    break;
                case "5":
                case "6":
                    {
                        if (is_movie.ToString() == "0")
                            return synopsis;
                        else if (is_movie.ToString() == "1")
                            return series_name;
                    }
                    break;
                default:
                    {
                        if (is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return synopsis;
                            else if (use_series_title == "1")
                                return series_name;
                        }
                    }
                    break;
            }

            return "";
        }

        public static string SecondLineCardText(string type, string data_type,
            string number, int is_movie, string use_series_title,
            string synopsis, string series_name, string focus_name, string series_category_name)
        {
            switch (type)
            {
                case "1":
                    {
                        if (data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return series_name;
                            else if (use_series_title == "1")
                                return series_category_name;
                        }
                    }
                    break;
                case "2":
                    {
                        if (data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return series_name;
                            else if (use_series_title == "1")
                                return series_category_name;
                        }
                        else if (data_type == "2")
                        {
                            if (is_movie.ToString() == "0")
                                return series_name;
                            else if (is_movie.ToString() == "1")
                                return series_name;
                        }
                    }
                    break;
                case "3":
                    {
                        if (data_type == "1" && is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return series_name;
                            else if (use_series_title == "1")
                                return series_category_name;
                        }
                        else if (data_type == "1" && is_movie.ToString() == "1")
                            return series_category_name;
                    }
                    break;
                case "4":
                    {
                        if (data_type == "1" && is_movie.ToString() == "1")
                            return series_category_name;
                    }
                    break;
                case "5":
                case "6":
                    {
                        if (is_movie.ToString() == "0")
                            return series_name;
                        else if (is_movie.ToString() == "1")
                            return series_category_name;
                    }
                    break;
                default:
                    {
                        if (is_movie.ToString() == "0")
                        {
                            if (use_series_title == "0")
                                return series_name;
                            else if (use_series_title == "1")
                                return series_category_name;
                        }
                    }
                    break;
            }

            return "";
        }
    }
}
