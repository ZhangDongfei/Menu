namespace ForCreateTemplate.WebService.Models.Response
{
    public class AppInfo
    {
        public int Status { get; set; }

        public Data Result { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 版权归属
        /// </summary>
        public string Copyright { get; set; }
    }
}