using System;
using System.IO;
using static rabota_13.Text;


namespace rabota_13
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            string filePath = "texts.txt";

            Text[] texts = new Text[]
            {
            new Text
            {
                id = 1,
                fontSize = 12,
                content = "текст",
                fontFamily = FontFamily.timesNewRoman,
                fontColor = FontColor.black,
                fontRegister = 0,
                allCapsSign = false
            },
             new Text
            {
                id = 2,
                fontSize = 12,
                content = "текст",
                fontFamily = FontFamily.timesNewRoman,
                fontColor = FontColor.black,
                fontRegister = 0,
                allCapsSign = false
            }
            };
            // сохранение текстов в файл
            SaveTexts(filePath, texts);
            // загрузка текстов из файла 
            Text[] loadedTexts = LoadTexts(filePath);
            Text textOne = loadedTexts[0];
            Text textTwo = loadedTexts[1];
            Console.WriteLine(textOne.GetHashCode());
            Console.WriteLine(textOne.ToString());
            Console.WriteLine("Увеличиваем размер первого текста на 2 ");
            textOne++;
            Console.WriteLine(textOne.ToString());
            Console.WriteLine("Уменьшаем размер первого текста на 2 ");
            textOne--;
            Console.WriteLine(textOne.ToString());
            Console.WriteLine("Загруженные из файла тексты");
            Console.WriteLine(textOne.ToString());
            Console.WriteLine(textTwo.ToString());           
            Console.WriteLine(loadedTexts[0].Equals(loadedTexts[1]));             
            Console.WriteLine("Реинициализируем текст");
            Text reinitializedText = new Text();
            reinitializedText.textRein(1, 14, "новый текст", "timesNewRoman", "black", 1, false);
            reinitializedText.reinFontSizeAndFontFamily(52, FontFamily.arial);
            reinitializedText.reinColor(FontColor.red);
            reinitializedText = !reinitializedText;
            Console.WriteLine(reinitializedText.ToString());
            Console.WriteLine("Cравнение загруженного и реинициализированного текстов");
            Console.WriteLine(reinitializedText.Equals(loadedTexts[1]));
            Console.ReadKey();
        }
        static void SaveTexts(string filePath, Text[] texts)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Text text in texts)
                {
                    writer.WriteLine($"{text.id},{text.fontSize},{text.content},{text.fontFamily},{text.fontColor},{text.fontRegister},{text.allCapsSign}");
                }
            }
        }
        static Text[] LoadTexts(string filePath)
        {
            Text[] texts = new Text[0];
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        Text text = new Text
                        {
                            id = int.Parse(parts[0]),
                            fontSize = int.Parse(parts[1]),
                            content = parts[2],
                            fontFamily = (FontFamily)Enum.Parse(typeof(FontFamily), parts[3]),
                            fontColor = (FontColor)Enum.Parse(typeof(FontColor), parts[4]),
                            fontRegister = sbyte.Parse(parts[5]),
                            allCapsSign = bool.Parse(parts[6])
                        };
                        Array.Resize(ref texts, texts.Length + 1);
                        texts[texts.Length - 1] = text;
                    }
                }
            }

            return texts;
        }
    }

    public class Text
    {
        public enum FontFamily
        {
            timesNewRoman,
            arial,
            comicSans
        }
        public enum FontColor
        {
            black,
            white,
            red
        }
        public int id, fontSize;
        public string content;
        public FontFamily fontFamily;
        public FontColor fontColor;
        public sbyte fontRegister;
        public bool allCapsSign;
        public Text()
        {
            id = 0;
            fontSize = 14;
            content = "";
            fontFamily = FontFamily.arial;
            fontColor = FontColor.black;
            fontRegister = 0;
            allCapsSign = false;

        }
        public void reinFontSizeAndFontFamily(int fontSize, FontFamily fontFamily)
        {
            this.fontSize = fontSize;
            this.fontFamily = fontFamily;
        }

        public void reinColor(FontColor fontColor)
        {
            this.fontColor = fontColor;
        }

        public int changeFontSize(int step)
        {
            fontSize += step;
            return fontSize;
        }

        public static Text operator !(Text text)
        {
            text.allCapsSign = !text.allCapsSign;
            return text;
        }

        public static Text operator ++(Text text)
        {
            text.changeFontSize(2);
            return text;
        }

        public static Text operator --(Text text)
        {
            text.changeFontSize(-2);
            return text;
        }
        public void textRein(int id, int fontSize, string content, string fontFamily, string fontColor, sbyte fontRegister, bool allCapsSign)
        {
            this.id = id;
            this.fontSize = fontSize;
            this.content = content;
            this.fontFamily = (FontFamily)Enum.Parse(typeof(FontFamily), fontFamily);
            this.fontColor = (FontColor)Enum.Parse(typeof(FontColor), fontColor);
            this.fontRegister = fontRegister;
            this.allCapsSign = allCapsSign;
        }

        public override bool Equals(object obj)
        {
            if (obj is Text other)
            {
                return fontSize == other.fontSize &&
                    content == other.content &&
                    fontFamily == other.fontFamily &&
                    fontColor == other.fontColor &&
                    fontRegister == other.fontRegister &&
                    allCapsSign == other.allCapsSign;
            }
            return false;
        }

        public string _fontFamily(Enum _enum)
        {
            switch (_enum)
            {
                case FontFamily.timesNewRoman:
                    return "Times New Roman";
                    break;
                case FontFamily.arial:
                    return "Arial";
                    break;
                case FontFamily.comicSans:
                    return "Comic Saans";
                    break;
                default:
                    break;
            }
            return null;
        }

        public string _fontColor(Enum _enum)
        {
            switch (_enum)
            {
                case FontColor.red:
                    return "Красный";
                    break;
                case FontColor.white:
                    return "Белый";
                    break;
                case FontColor.black:
                    return "Черный";
                    break;
                default:
                    break;
            }
            return null;
        }

        public string _fontRegister(sbyte fontRegister)
        {
            switch (fontRegister)
            {
                case -1:
                    return "нижний";
                    break;
                case 1:
                    return "верхний";
                    break;
                default:
                    return "нормальный";
                    break;
            }
        }


        public override int GetHashCode()
        {
            int hashCode = 0;

            foreach (char c in content)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        if (IsLatin(c))
                        {
                            hashCode -= c - 'a' + 1;
                        }
                        else
                        {
                            hashCode += c - 'а' + 1;
                        }
                    }
                    else
                    {
                        if (IsLatin(c))
                        {
                            hashCode -= c - 'A' + 1 ;
                        }
                        else
                        {
                            hashCode += c - 'А' + 1 ;
                        }
                    }
                }
            }

            return hashCode;
        }

        public bool IsLatin(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }
        public override string ToString()
        {
            return $"{id}. «{content}» [{_fontFamily(fontFamily)}][{fontSize}][{_fontColor(fontColor)}][{_fontRegister(fontRegister)}]";
        }
        
    }
}
