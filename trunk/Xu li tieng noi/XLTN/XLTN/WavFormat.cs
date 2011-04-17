using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace XLTN
{
    public class WavFormat
    {
        public string ChunkID;
        public int ChunkSize;
        public string Format;

        public string Subchunk1ID;
        public int Subchunk1Size;
        public AudioFormatType AudioFormat;
        public int NumChanels;
        public long SampleRate;
        public long ByteRate;
        public long BlockAlign;
        public int BitsPerSample;
        public string Subchunk2ID;
        public int Subchunk2Size;
        public byte[] Data;

        public byte[] GetWAVEData(string strWAVEPath)
        {
            try
            {
                FileStream fs = new FileStream(@strWAVEPath, FileMode.Open, FileAccess.Read);
                byte[] arrfile = new byte[fs.Length - 44];
                fs.Position = 44;
                fs.Read(arrfile, 0, arrfile.Length);
                fs.Close();
                return arrfile;
            }
            catch (IOException ioex)
            {
                throw ioex;
            }
        }

        public void ProcessWAVEData(string strWAVEPath)
        {
            FileStream fs = new FileStream(strWAVEPath,FileMode.Open,FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            try
            {
                ChunkID = br.ReadInt32().ToString();
                ChunkSize = br.ReadInt32();
                Format = br.ReadInt32().ToString();
                Subchunk1ID = br.ReadInt32().ToString();
                Subchunk2Size = br.ReadInt32();
                int _audioFormat = br.ReadInt16();
                NumChanels = br.ReadInt16();
                SampleRate = br.ReadInt32();
                ByteRate = br.ReadInt32();
                BlockAlign = br.ReadInt16();
                BitsPerSample = br.ReadInt16();
                Subchunk2ID = br.ReadInt32().ToString();
                Subchunk1Size = br.ReadInt32();

                Data = new Byte[fs.Length-44];
                fs.Position = 44;
                fs.Read(Data,0,Data.Length);

                //Length = (int)fs.Length - 8;
                //fs.Position = 22;
                //Channels = br.ReadInt16(); //1
                //fs.Position = 24;
                //SampleRate = br.ReadInt32(); //8000
                //fs.Position = 34;
                //BitsPerSample = br.ReadInt16(); //16
                //DataLength = (int)fs.Length - 44;
                //byte[] arrfile = new byte[fs.Length - 44];
                //fs.Position = 44;
                //fs.Read(arrfile, 0, arrfile.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }

        
    }

    public enum AudioFormatType
    {}
}
