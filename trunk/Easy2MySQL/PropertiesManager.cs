
// PropertiesManager.cs
using System;
using System.IO;
using System.Collections.Generic;

namespace Easy2
{
	/**
	 * @class PropertiesManager
	 * @brief 프로퍼티 파일 매니저(읽기, 쓰기 관리)
	 */
	class PropertiesManager
	{
		/**
		 * @brief 생성자입니다.
		 * @param path : PropertiesManager 개체가 캡슐화할 파일의 상대 또는 절대 경로입니다. 
		 * @param fileAccess : 파일을 열거나 만드는 방법을 결정하는 FileMode 상수입니다.
		 */
		public PropertiesManager(string path, FileAccess fileAccess)
		{
			this.propertyPath = path;
			this.propertiesData = new Dictionary<string, string>();
			this.fileAccess = fileAccess;
		}

		/**
		 * @brief PropertiesManager 개체에 지정된 상대 또는 절대 경로의 파일을 엽니다.
		 */
		public void Open()
		{
			this.fileStream = this.fileAccess == FileAccess.Read ?
				new FileStream(this.propertyPath, FileMode.Open, FileAccess.Read) :
				new FileStream(this.PropertyPath, FileMode.Create, FileAccess.Write);

			if (this.fileAccess == FileAccess.Read)
				this.streamReader = new StreamReader(this.fileStream, System.Text.Encoding.UTF8);
			else
				this.streamWriter = new StreamWriter(this.fileStream, System.Text.Encoding.UTF8);
		}

		/**
		 * @brief PropertiesManager 개체에 지정된 상대 또는 절대 경로의 파일을 읽어옵니다.
		 * @return 읽어온 데이터의 길이입니다.
		 */
		public int Read()
		{
			this.propertyDataLength = 0;
			while(!this.streamReader.EndOfStream)
			{
				string[] splitData = this.streamReader.ReadLine().Split(new string[]{" = "}, StringSplitOptions.RemoveEmptyEntries);
				this.propertiesData[splitData[0]] = splitData[1];
				this.propertyDataLength++;
			}

			return propertyDataLength;
		}

		/**
		 * @brief PropertiesManager 개체에 지정된 상대 또는 절대 경로의 파일을 씁니다.
		 * @return 쓴 데이터의 길이입니다.
		 */
		public int Write()
		{
			return this.Write(this.propertiesData);
		}

		/**
		 * @brief PropertiesManager 개체에 지정된 상대 또는 절대 경로의 파일을 씁니다.
		 * @param propertiesData : 파일에 쓸 데이터입니다.
		 * @return 쓴 데이터의 길이입니다.
		 */
		public int Write(Dictionary<string, string> propertiesData)
		{
			int writeCount = 0;
			Dictionary<string, string>.Enumerator e = propertiesData.GetEnumerator();
			while(e.MoveNext())
			{
				// UTF-8 문자체계에서는 \r\n을 해야 개행문자가 올바르게 입력된다.
				string buffer = string.Format("{0} = {1}\r\n", e.Current.Key, e.Current.Value);
				this.streamWriter.Write(buffer);
				writeCount++;
			}
			
			return writeCount;
		}

		/**
		 * @brief 열려진 파일 객체를 닫습니다.(반드시 사용후 호출해야 함)
		 */
		public void Close()
		{
			if(this.fileAccess == FileAccess.Read)
			{
				this.streamReader.Close();
			}
			else
			{
				this.streamWriter.Close();
			}
			this.fileStream.Close();
			
		}

		/**
		 * @brief propertyPath의 프로퍼티입니다.
		 */
		public string PropertyPath
		{
			get
			{
				return this.propertyPath;
			}
			set
			{
				this.propertyPath = PropertyPath;
			}
		}

		/**
		 * @brief PropertyManager의 인덱서입니다.
		 */
		public string this[string index]
		{
			get
			{
				return this.propertiesData[index];
			}
			set
			{
				this.propertiesData[index] = value;
			}
		}

		private string propertyPath;
		private Dictionary<string, string> propertiesData;
		private FileStream fileStream;
		private FileAccess fileAccess;
		private StreamReader streamReader;
		private StreamWriter streamWriter;
		private int propertyDataLength;
	}
}
