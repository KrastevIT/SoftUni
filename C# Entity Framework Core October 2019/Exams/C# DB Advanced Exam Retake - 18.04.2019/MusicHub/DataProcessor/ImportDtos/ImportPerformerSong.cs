using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Song")]
    public class ImportPerformerSong
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
