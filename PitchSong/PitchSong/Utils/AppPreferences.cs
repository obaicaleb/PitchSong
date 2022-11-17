using System;
using Xamarin.Essentials;

namespace PitchSong.Utils
{
    public static class AppPreferences
    {
        public static void ClearAll()
        {
            Preferences.Clear();
        }

        public static void ClearSharedName(string sharedName)
        {
            Preferences.Clear(sharedName);
        }

        public static bool Contains(string key)
        {
            return Preferences.ContainsKey(key);
        }

        public static bool Contains(string key, string sharedName)
        {
            return Preferences.ContainsKey(key, sharedName);
        }

        public static void Remove(string key)
        {
            Preferences.Remove(key);
        }

        public static void Remove(string key, string sharedName)
        {
            Preferences.Remove(key, sharedName);
        }

        public static void Insert(string key, float value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, float value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, double value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, double value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, int value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, int value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, bool value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, bool value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, string value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, string value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, long value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, long value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static void Insert(string key, DateTime value)
        {
            if (Contains(key))
            {
                Remove(key);
                Preferences.Set(key, value);
            }
            else
            {
                Preferences.Set(key, value);
            }
        }

        public static void Insert(string key, DateTime value, string sharedName)
        {
            if (Contains(key, sharedName))
            {
                Remove(key, sharedName);
                Preferences.Set(key, value, sharedName);
            }
            else
            {
                Preferences.Set(key, value, sharedName);
            }
        }

        public static float Get(string key, float defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static float Get(string key, float defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static double Get(string key, double defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static double Get(string key, double defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static int Get(string key, int defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static int Get(string key, int defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static bool Get(string key, bool defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static bool Get(string key, bool defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static string Get(string key, string defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static string Get(string key, string defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static long Get(string key, long defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static long Get(string key, long defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static DateTime Get(string key, DateTime defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public static DateTime Get(string key, DateTime defaultValue, string sharedName)
        {
            return Preferences.Get(key, defaultValue, sharedName);
        }

        public static DateTime GetLastDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
    }
}

