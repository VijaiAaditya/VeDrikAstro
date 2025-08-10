namespace VeDrik.Astro.Data;

public static class VedicConstants
{
    public static string[] VedicMonths { get; } =
    [
        "Chaitra", "Vaishakha", "Jyeshtha", "Ashadha", "Shravana", "Bhadrapada", "Ashwin", "Kartika", "Margashirsha", "Pausha", "Magha", "Phalguna"
    ];

    public static string[] TithiNames { get; } =
    [
        "Pratipada", "Dvitiya", "Tritiya", "Chaturthi", "Panchami", "Shashthi", "Saptami", "Ashtami", "Navami", "Dashami", "Ekadashi", "Dwadashi", "Trayodashi", "Chaturdashi", "Purnima/Amavasya"
    ];

    public static string[] NakshatraNames { get; } =
    [
        "Ashwini", "Bharani", "Krittika", "Rohini", "Mrigashirsha", "Ardra", "Punarvasu", "Pushya", "Ashlesha",
        "Magha", "Purva Phalguni", "Uttara Phalguni", "Hasta", "Chitra", "Swati", "Vishakha", "Anuradha", "Jyeshtha",
        "Mula", "Purva Ashadha", "Uttara Ashadha", "Shravana", "Dhanishta", "Shatabhisha", "Purva Bhadrapada", "Uttara Bhadrapada", "Revati"
    ];

    public static string[] NakshatraRulers { get; } =
    [
        "Ketu", "Venus", "Sun", "Moon", "Mars", "Rahu", "Jupiter", "Saturn",
        "Mercury", "Ketu", "Venus", "Sun", "Moon", "Mars", "Rahu", "Jupiter",
        "Saturn", "Mercury", "Ketu", "Venus", "Sun", "Moon", "Mars", "Rahu",
        "Jupiter", "Saturn", "Mercury"
    ];

    public static string[] YogaNames { get; } =
    [
        "Vishkambha", "Priti", "Ayushman", "Saubhagya", "Shobhana", "Atiganda", "Sukarman", "Dhriti", "Shoola",
        "Ganda", "Vriddhi", "Dhruva", "Vyaghata", "Harshana", "Vajra", "Siddhi", "Vyatipata", "Variyana",
        "Parigha", "Shiva", "Siddha", "Sadhya", "Shubha", "Shukla", "Brahma", "Indra", "Vaidhriti"
    ];

    public static string[] KaranaNames { get; } =
    [
        "Bava", "Balava", "Kaulava", "Taitila", "Garaja", "Vanija", "Vishti", "Shakuni", "Chatushpada", "Nagava", "Kimstughna"
    ];

    public static string[] Weekdays { get; } =
    [
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
    ];

    public static string[] HoraLords { get; } =
    [
        "Sun", "Venus", "Mercury", "Moon", "Saturn", "Jupiter", "Mars"
    ];

    public static string[] RasiNames { get; } =
    [
        "Mesh", "Vrish", "Mithun", "Kark", "Simh", "Kany", "Tula", "Vrischik", "Dhanu", "Makar", "Kumbh", "Meen"
    ];
    public static string[] RasiNamesFull { get; } =
    [
        "Mesh (Aries)", "Vrish (Taurus)", "Mithun (Gemini)", "Kark (Cancer)", "Simh (Leo)", "Kany (Virgo)", "Tula (Libra)", "Vrischik (Scorpio)", "Dhanu (Sagittarius)", "Makar (Capricorn)", "Kumbh (Aquarius)", "Meen (Pisces)"
    ];

    public static string[] PlanetNames { get; } =
    [
        "Surya (Su)", "Chandra (Ch)", "Budha (Bu)", "Shukra (Sh)", "Mangal (Ma)",
        "Guru (Gu)", "Shani (Sa)", "Arun (Ur)", "Varun (Ne)", "Yam (Pl)",
        "Rahu (Ra)", "Ketu (Ke)"
    ];

    public static string[] RahuKaalTable { get; } =
    [
        "07:30-09:00", "15:00-16:30", "12:00-13:30", "13:30-15:00", "10:30-12:00", "09:00-10:30", "16:30-18:00"
    ];

    public static string[] YamaKaalTable { get; } =
    [
        "06:00-07:30", "09:00-10:30", "10:30-12:00", "15:00-16:30", "16:30-18:00", "13:30-15:00", "12:00-13:30"
    ];
}
