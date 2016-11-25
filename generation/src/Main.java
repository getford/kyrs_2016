import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Random random = new Random();

        String fileName = "D://text.txt";
        String text = null;
        File file = new File(fileName);

//
        //String[] arrKino = new String[21];
        //arrKino[0] = "3D Кино в Замке";
        //arrKino[1] = "Falcon Club Бутик Кино";
        //arrKino[2] = "Аврора";
        //arrKino[3] = "Автокинотеатр";
        //arrKino[4] = "АртКинотеатр в ТЦ \"Титан\"";
        //arrKino[5] = "Беларусь";
        //arrKino[6] = "Берестье";
        //arrKino[7] = "Дворец Республики (3D-кинозал)";
        //arrKino[8] = "Дом Кино";
        //arrKino[9] = "Киев";
        //arrKino[10] = "Комсомолец";
        //arrKino[11] = "Мир";
        //arrKino[12] = "Москва";
        //arrKino[13] = "Октябрь";
        //arrKino[14] = "Пионер";
        //arrKino[15] = "Победа";
        //arrKino[16] = "Ракета";
        //arrKino[17] = "Салют";
        //arrKino[18] = "Silver Screen в ТРЦ \"Галилео\"";
        //arrKino[19] = "Silver Screen ТРЦ \"Арена-Сити\"";
        //arrKino[20] = "Центральный";
        //
        //String[] arrTimeWorkKino = new String[21];
        //arrTimeWorkKino[0] = "ПТ–СБ с 10:00 до 24:00";
        //arrTimeWorkKino[1] = "ПН–ВС с 14:00 до 24:30";
        //arrTimeWorkKino[2] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[3] = "ПН–ВС с 21:00";
        //arrTimeWorkKino[4] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[5] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[6] = "ПН–ПТ с 12:00 до 23:30";
        //arrTimeWorkKino[7] = "ПН–ПТ с 12:00 до 23:30";
        //arrTimeWorkKino[8] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[9] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[10] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[11] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[12] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[13] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[14] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[15] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[16] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[17] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkKino[18] = "ПН–ВС с 09:00 до 24:00";
        //arrTimeWorkKino[19] = "ПН–ВС с 09:00 до 24:00";
        //arrTimeWorkKino[20] = "ПН–ВС с 11:30 до 21:30";
        //
        //String[] arrTelKino = new String[21];
        //arrTelKino[0] = "375 17 3095475";
        //arrTelKino[1] = "375 44 7710171";
        //arrTelKino[2] = "375 17 3638012";
        //arrTelKino[3] = "375 17 3369964";
        //arrTelKino[4] = "375 17 2094034";
        //arrTelKino[5] = "375 17 2079776";
        //arrTelKino[6] = "375 17 2728791";
        //arrTelKino[7] = "375 17 2299094";
        //arrTelKino[8] = "375 17 2803526";
        //arrTelKino[9] = "375 17 2336579";
        //arrTelKino[10] = "375 17 2953224";
        //arrTelKino[11] = "375 17 2843771";
        //arrTelKino[12] = "375 17 2031448";
        //arrTelKino[13] = "375 17 2929426";
        //arrTelKino[14] = "375 17 3276487";
        //arrTelKino[15] = "375 17 2037766";
        //arrTelKino[16] = "375 17 2982500";
        //arrTelKino[17] = "375 17 3674167";
        //arrTelKino[18] = "375 29 6216886";
        //arrTelKino[19] = "375 29 1204009";
        //arrTelKino[20] = "375 17 2003416";
        //
        //String[] arrAddressKinoHouse = new String[21];
        //arrAddressKinoHouse[0] = "65";
        //arrAddressKinoHouse[1] = "20";
        //arrAddressKinoHouse[2] = "23";
        //arrAddressKinoHouse[3] = "2";
        //arrAddressKinoHouse[4] = "104";
        //arrAddressKinoHouse[5] = "25";
        //arrAddressKinoHouse[6] = "28";
        //arrAddressKinoHouse[7] = "1/1";
        //arrAddressKinoHouse[8] = "18";
        //arrAddressKinoHouse[9] = "31";
        //arrAddressKinoHouse[10] = "39";
        //arrAddressKinoHouse[11] = "4А";
        //arrAddressKinoHouse[12] = "13";
        //arrAddressKinoHouse[13] = "73";
        //arrAddressKinoHouse[14] = "20";
        //arrAddressKinoHouse[15] = "20";
        //arrAddressKinoHouse[16] = "3";
        //arrAddressKinoHouse[17] = "150А";
        //arrAddressKinoHouse[18] = "6";
        //arrAddressKinoHouse[19] = "84";
        //arrAddressKinoHouse[20] = "13";
        //
        //
        //String[] arrAddressKino = new String[21];
        //arrAddressKino[0] = "пр-т Победителей";
        //arrAddressKino[1] = "пр-т Победителей";
        //arrAddressKino[2] = "ул. Притыцкого";
        //arrAddressKino[3] = "Меньковский тракт";
        //arrAddressKino[4] = "пр-т Дзержинского";
        //arrAddressKino[5] = "ул. Романовская Слобода";
        //arrAddressKino[6] = "пр-т Газеты Правда";
        //arrAddressKino[7] = "пл. Октябрьская";
        //arrAddressKino[8] = "ул. Толбухина";
        //arrAddressKino[8] = "ул. Каховская";
        //arrAddressKino[10] = "ул. Жилуновича";
        //arrAddressKino[11] = "ул. Козлова";
        //arrAddressKino[12] = "пр-т Победителей";
        //arrAddressKino[13] = "пр-т Независимости";
        //arrAddressKino[14] = "ул. Энгельса";
        //arrAddressKino[15] = "ул. Интернациональная";
        //arrAddressKino[16] = "пер. Рабочий";
        //arrAddressKino[17] = "пр-т Рокоссовского";
        //arrAddressKino[18] = "ул. Бобруйская";
        //arrAddressKino[19] = "пр-т Победителей";
        //arrAddressKino[20] = "пр-т Независимости";
        //
        //String[] arrTheater = new String[15];
        //arrTheater[0] = "Альфа-театр";
        //arrTheater[1] = "Большой театр оперы и балета";
        //arrTheater[2] = "Театр Геннадия Гладкова";
        //arrTheater[3] = "Театр музкомедии";
        //arrTheater[4] = "Театр кукол";
        //arrTheater[5] = "Театр юного зрителя";
        //arrTheater[6] = "Театр Белорусской Армии";
        //arrTheater[7] = "Театр им. М. Горького";
        //arrTheater[8] = "Театр им. Янки Купалы";
        //arrTheater[9] = "Новый драматический театр";
        //arrTheater[10] = "Русский Детский Театр";
        //arrTheater[11] = "РТБД";
        //arrTheater[12] = "СХТ";
        //arrTheater[13] = "Театр-студия киноактёра";
        //arrTheater[14] = "Молодежный театр";
        //
        //String[] arrTimeWorkTheater = new String[15];
        //arrTimeWorkTheater[0] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkTheater[1] = "ПН–ВС с 10:00 до 20:00";
        //arrTimeWorkTheater[2] = "ПН–ВС с 10:00 до 19:00";
        //arrTimeWorkTheater[3] = "ПН–ВС с 10:00 до 18:00";
        //arrTimeWorkTheater[4] = "ПН–ВС с 10:00 до 21:00";
        //arrTimeWorkTheater[5] = "ПН–ВС с 10:00 до 23:00";
        //arrTimeWorkTheater[6] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkTheater[7] = "ПН–ВС с 10:00 до 23:00";
        //arrTimeWorkTheater[8] = "ПН–ВС с 09:00 до 19:00";
        //arrTimeWorkTheater[9] = "ПН–ВС с 10:00 до 21:00";
        //arrTimeWorkTheater[10] = "ПН–ВС с 10:00 до 23:00";
        //arrTimeWorkTheater[11] = "ПН–ВС с 09:00 до 19:00";
        //arrTimeWorkTheater[12] = "ПН–ВС с 10:00 до 23:00";
        //arrTimeWorkTheater[13] = "ПН–ВС с 10:00 до 23:00";
        //arrTimeWorkTheater[14] = "ПН–ВС с 10:00 до 23:00\n";
        //
        //String[] arrAddressTheater = new String[15];
        //arrAddressTheater[0] = "ул. Октябрьская";
        //arrAddressTheater[1] = "пл. Парижской коммуны";
        //arrAddressTheater[2] = "пр-т Независимости";
        //arrAddressTheater[3] = "ул. Мясникова";
        //arrAddressTheater[4] = "ул. Энгельса";
        //arrAddressTheater[5] = "ул. Энгельса";
        //arrAddressTheater[6] = "ул. Красноармейская";
        //arrAddressTheater[7] = "ул. Володарского";
        //arrAddressTheater[8] = "ул. Энгельса";
        //arrAddressTheater[9] = "ул. Лизы Чайкиной";
        //arrAddressTheater[10] = "ул. Берсона";
        //arrAddressTheater[11] = "ул. Кропоткина";
        //arrAddressTheater[12] = "ул. Октябрьская";
        //arrAddressTheater[13] = "пр-т Победителей";
        //arrAddressTheater[14] = "ул. Козлова";
        //
        //String[] arrAddressHouseTheater = new String[15];
        //arrAddressHouseTheater[0] = "5";
        //arrAddressHouseTheater[1] = "1";
        //arrAddressHouseTheater[2] = "25";
        //arrAddressHouseTheater[3] = "44";
        //arrAddressHouseTheater[4] = "20";
        //arrAddressHouseTheater[5] = "26";
        //arrAddressHouseTheater[6] = "3";
        //arrAddressHouseTheater[7] = "5";
        //arrAddressHouseTheater[8] = "7";
        //arrAddressHouseTheater[9] = "16";
        //arrAddressHouseTheater[10] = "1A";
        //arrAddressHouseTheater[11] = "44";
        //arrAddressHouseTheater[12] = "5";
        //arrAddressHouseTheater[13] = "13";
        //arrAddressHouseTheater[14] = "17";
        //
        //String[] arrTelTheater = new String[15];
        //arrTelTheater[0] = "375 17 3278716";
        //arrTelTheater[1] = "375 17 2392864";
        //arrTelTheater[2] = "375 29 5567718";
        //arrTelTheater[3] = "375 17 2008126";
        //arrTelTheater[4] = "375 17 3270532";
        //arrTelTheater[5] = "375 17 2947872";
        //arrTelTheater[6] = "375 17 3995898";
        //arrTelTheater[7] = "375 17 2003966";
        //arrTelTheater[8] = "375 17 3271717";
        //arrTelTheater[9] = "375 17 2912460";
        //arrTelTheater[10] = "375 33 3333034";
        //arrTelTheater[11] = "375 17 3859751";
        //arrTelTheater[12] = "375 17 3286638";
        //arrTelTheater[13] = "375 29 1310745";
        //arrTelTheater[14] = "375 17 2392721";
        //
        //String[] arrNightClub = new String[10];
        //arrNightClub[0] = "Dozari";
        //arrNightClub[1] = "Madison Royal Club";
        //arrNightClub[2] = "Millennium";
        //arrNightClub[3] = "Next";
        //arrNightClub[4] = "Re:Public";
        //arrNightClub[5] = "Джек клаб";
        //arrNightClub[6] = "Овертайм / Overtime";
        //arrNightClub[7] = "НЛО";
        //arrNightClub[8] = "Титан";
        //arrNightClub[9] = "Mojito";
        //
        //String[] arrTimeWorkNightClub = new String[10];
        //arrTimeWorkNightClub[0] = "СР–ВС с 22:00 до 06:00";
        //arrTimeWorkNightClub[1] = "СР–ВС с 23:00 до 06:00";
        //arrTimeWorkNightClub[2] = "ПН-ВС с 24:00 до 24:00";
        //arrTimeWorkNightClub[3] = "ЧТ–ВС с 23:00 до 06:00";
        //arrTimeWorkNightClub[4] = "ПН-ВС с 13.00 до 20.00 (до 04:00)";
        //arrTimeWorkNightClub[5] = "ПН–ПТ с 11:00 до 06:00";
        //arrTimeWorkNightClub[6] = "ЧТ–ВС с 21:00 до 06:00";
        //arrTimeWorkNightClub[7] = "ВТ–ВС с 12:00 до 06:00";
        //arrTimeWorkNightClub[8] = "ПН–ВС с 12:00 до 02:00";
        //arrTimeWorkNightClub[9] = "ПН–ВС с 12:00 до 06:00";
        //
        //String[] arrAddressNightClub = new String[10];
        //arrAddressNightClub[0] = "пр-т Независимости";
        //arrAddressNightClub[1] = "ул. Тимирязева";
        //arrAddressNightClub[2] = "пр-т Победителей";
        //arrAddressNightClub[3] = "ул. Кирова";
        //arrAddressNightClub[4] = "ул. Притыцкого";
        //arrAddressNightClub[5] = "ул. Немига";
        //arrAddressNightClub[6] = "пр-т Победителей";
        //arrAddressNightClub[7] = "ул. Якуба Колоса";
        //arrAddressNightClub[8] = "пр-т Дзержинского";
        //arrAddressNightClub[9] = "пр-т Независимости";
        //
        //String[] arrHouseNightClub = new String[10];
        //arrHouseNightClub[0] = "58";
        //arrHouseNightClub[1] = "9";
        //arrHouseNightClub[2] = "7";
        //arrHouseNightClub[3] = "13";
        //arrHouseNightClub[4] = "62";
        //arrHouseNightClub[5] = "12";
        //arrHouseNightClub[6] = "4";
        //arrHouseNightClub[7] = "37";
        //arrHouseNightClub[8] = "104";
        //arrHouseNightClub[9] = "58";
        //
        //String[] arrTelNightClub = new String[10];
        //arrTelNightClub[0] = "375 29 3452233";
        //arrTelNightClub[1] = "375 29 6190040";
        //arrTelNightClub[2] = "375 29 1770077";
        //arrTelNightClub[3] = "375 44 7187777";
        //arrTelNightClub[4] = "375 29 1103535";
        //arrTelNightClub[5] = "375 29 1375795";
        //arrTelNightClub[6] = "375 29 1414414";
        //arrTelNightClub[7] = "375 17 2902080";
        //arrTelNightClub[8] = "375 44 7091010";
        //arrTelNightClub[9] = "375 17 2900560";
        //
        //String[] arrBouling = new String[3];
        //arrBouling[0] = "Титан";
        //arrBouling[1] = "Expobel";
        //arrBouling[2] = "Боулинг хаус";
        //
        //String[] arrConcert = new String[13];
        //arrConcert[0] = "Prime Hall";
        //arrConcert[1] = "Re:Public";
        //arrConcert[2] = "Белгосфилармония";
        //arrConcert[3] = "Граффити";
        //arrConcert[4] = "Дворец Республики";
        //arrConcert[5] = "Дворец спорта";
        //arrConcert[6] = "ДК МАЗ";
        //arrConcert[7] = "ДК МТЗ";
        //arrConcert[8] = "Doodah King";
        //arrConcert[9] = "Койот";
        //arrConcert[10] = "КЗ Минск";
        //arrConcert[11] = "Минск-арена";
        //arrConcert[12] = "Чижовка-Арена";
        //
        //String[] arrTelConcert = new String[13];
        //arrTelConcert[0] = "375 44 5021111";
        //arrTelConcert[1] = "375 29 1103535";
        //arrTelConcert[2] = "375 17 3311617";
        //arrTelConcert[3] = "375 33 6384444";
        //arrTelConcert[4] = "375 17 2299039";
        //arrTelConcert[5] = "375 17 2267096";
        //arrTelConcert[6] = "375 17 2428204";
        //arrTelConcert[7] = "375 17 2302032";
        //arrTelConcert[8] = "375 29 1031000";
        //arrTelConcert[9] = "375 17 2680175";
        //arrTelConcert[10] = "375 17 3271597";
        //arrTelConcert[11] = "375 29 6382646";
        //arrTelConcert[12] = "375 17 3300680";
        //
        //String[] arrTimeWorkConcert = new String[13];
        //arrTimeWorkConcert[0] = "ПН–ВС с 00:00 до 24:00";
        //arrTimeWorkConcert[1] = "ПН-ВС с 13.00 до 20.00 (до 04:00)";
        //arrTimeWorkConcert[2] = "ПН-ВС с 13.00 до 20.00";
        //arrTimeWorkConcert[3] = "ПН–ВС с 19:00 до 23:00";
        //arrTimeWorkConcert[4] = "ПН–ПТ с 12:00 до 23:30";
        //arrTimeWorkConcert[5] = "ПН–ПТ с 11:00 до 19:00";
        //arrTimeWorkConcert[6] = "ПН–ПТ с 11:00 до 19:00";
        //arrTimeWorkConcert[7] = "ПН–ВС с 09:00 до 21:00";
        //arrTimeWorkConcert[8] = "ПН–ВС с 17:00 до 05:00";
        //arrTimeWorkConcert[9] = "ЧТ–СБ с 18:00 до 06:00";
        //arrTimeWorkConcert[10] = "ПН–ВС с 09:00 до 21:00";
        //arrTimeWorkConcert[11] = "ПН–ВС с 08:00 до 23:00";
        //arrTimeWorkConcert[12] = "ПН–ВС с 07:00 до 23:00";
        //
        //String[] arrAddressConsert = new String[13];
        //arrAddressConsert[0] = "пр-т Победителей";
        //arrAddressConsert[1] = "ул. Притыцкого";
        //arrAddressConsert[2] = "пр-т Независимости";
        //arrAddressConsert[3] = "пер. Калинина";
        //arrAddressConsert[4] = "пл. Октябрьская";
        //arrAddressConsert[5] = "пр-т Победителей";
        //arrAddressConsert[6] = "пр-т Партизанский";
        //arrAddressConsert[7] = "ул. Долгобродская";
        //arrAddressConsert[8] = "ул. Берсона";
        //arrAddressConsert[9] = "пр-т Независимости";
        //arrAddressConsert[10] = "ул. Октябрьская";
        //arrAddressConsert[11] = "пр-т Победителей";
        //arrAddressConsert[12] = "ул. Ташкентская";
        //
        //String[] arrAddressHouseConcert = new String[13];
        //arrAddressHouseConcert[0] = "65";
        //arrAddressHouseConcert[1] = "62";
        //arrAddressHouseConcert[2] = "50";
        //arrAddressHouseConcert[3] = "16";
        //arrAddressHouseConcert[4] = "1";
        //arrAddressHouseConcert[5] = "4";
        //arrAddressHouseConcert[6] = "117";
        //arrAddressHouseConcert[7] = "24";
        //arrAddressHouseConcert[8] = "14";
        //arrAddressHouseConcert[9] = "117";
        //arrAddressHouseConcert[10] = "5";
        //arrAddressHouseConcert[11] = "111";
        //arrAddressHouseConcert[12] = "19";
        //
        //
        //String[] arrVistovka = new String[15];
        //arrVistovka[0] = "Государственный литературный музей Якуба Коласа";
        //arrVistovka[1] = "Музей авиационной техники-Боровая";
        //arrVistovka[2] = "Музей истории белорусского кино";
        //arrVistovka[3] = "Музей современного изобразительного искусства";
        //arrVistovka[4] = "Белорусский государственный музей истории ВОВ";
        //arrVistovka[5] = "Историко-культурный комплекс \"Линия Сталина\"";
        //arrVistovka[6] = "Музей Аливарии";
        //arrVistovka[7] = "Музей валунов";
        //arrVistovka[8] = "Музей истории Белорусской железной дороги";
        //arrVistovka[9] = "Музей истории Минска";
        //arrVistovka[10] = "Музей книги национальной библиотеки Беларуси";
        //arrVistovka[11] = "Музей природы и экологии Беларуси";
        //arrVistovka[12] = "Музей старинных фотографий и фотоаппаратов";
        //arrVistovka[13] = "Национальный исторический музей Беларуси";
        //arrVistovka[14] = "Национальный художественный музей Республики Беларусь";
        //
        //String[] arrTimeWorkVistovka = new String[15];
        //arrTimeWorkVistovka[0] = "СР–СБ с 10:00 до 17:30";
        //arrTimeWorkVistovka[1] = "ВТ–ПТ с 10:00 до 18:00";
        //arrTimeWorkVistovka[2] = "ВТ–ВС с 10:00 до 19:00";
        //arrTimeWorkVistovka[3] = "ВТ–СБ с 10:00 до 19:00";
        //arrTimeWorkVistovka[4] = "ЧТ–ВС с 10:00 до 18:00";
        //arrTimeWorkVistovka[5] = "ПН–ВС с 10:00 до 22:00";
        //arrTimeWorkVistovka[6] = "СР–ВС с 16:00 до 19:30";
        //arrTimeWorkVistovka[7] = "ПН–ВС с 10:00 до 20:00";
        //arrTimeWorkVistovka[8] = "ПН–ПТ с 09:00 до 18:00";
        //arrTimeWorkVistovka[9] = "СР–ВС с 11:00 до 19:00";
        //arrTimeWorkVistovka[10] = "ПН–ЧТ с 09:00 до 17:00";
        //arrTimeWorkVistovka[11] = "ПН–ВС с 11:00 до 19:00";
        //arrTimeWorkVistovka[12] = "ПН–ВС с 11:00 до 17:00";
        //arrTimeWorkVistovka[13] = "ПН–ВС с 11:00 до 19:00";
        //arrTimeWorkVistovka[14] = "ПН–ВС с 11:00 до 19:00";
        //
        //String[] arrAddressVistovka = new String[15];
        //arrAddressVistovka[0] = "ул. Академическая";
        //arrAddressVistovka[1] = "д. Боровая";
        //arrAddressVistovka[2] = "ул. Свердлова";
        //arrAddressVistovka[3] = "пр-т Независимости";
        //arrAddressVistovka[4] = "пр-т Победителей";
        //arrAddressVistovka[5] = "д. Лошаны";
        //arrAddressVistovka[6] = "ул. Киселева";
        //arrAddressVistovka[7] = "ул. Академика Купревича";
        //arrAddressVistovka[8] = "ул. Чкалова";
        //arrAddressVistovka[9] = "ул. Революционная";
        //arrAddressVistovka[10] = "пр-т Независимости";
        //arrAddressVistovka[11] = "ул. К. Маркса";
        //arrAddressVistovka[12] = "пр-т Притыцкого";
        //arrAddressVistovka[13] = "ул. К. Маркса";
        //arrAddressVistovka[14] = "ул. Ленина";
        //
        //String[] arrAddressHouseVistovka = new String[15];
        //arrAddressHouseVistovka[0] = "5";
        //arrAddressHouseVistovka[1] = "1";
        //arrAddressHouseVistovka[2] = "4";
        //arrAddressHouseVistovka[3] = "47";
        //arrAddressHouseVistovka[4] = "8";
        //arrAddressHouseVistovka[5] = "1";
        //arrAddressHouseVistovka[6] = "30";
        //arrAddressHouseVistovka[7] = "1";
        //arrAddressHouseVistovka[8] = "7";
        //arrAddressHouseVistovka[9] = "10";
        //arrAddressHouseVistovka[10] = "116";
        //arrAddressHouseVistovka[11] = "12";
        //arrAddressHouseVistovka[12] = "10";
        //arrAddressHouseVistovka[13] = "12";
        //arrAddressHouseVistovka[14] = "20";
        //
        //String[] arrTelVistovka = new String[15];
        //arrTelVistovka[0] = "375 17 2841702";
        //arrTelVistovka[1] = "375 17 5052960";
        //arrTelVistovka[2] = "375 17 3271075";
        //arrTelVistovka[3] = "375 17 2848621";
        //arrTelVistovka[4] = "375 17 2030792";
        //arrTelVistovka[5] = "375 44 7163469";
        //arrTelVistovka[6] = "375 17 2395805";
        //arrTelVistovka[7] = "375 17 2893022";
        //arrTelVistovka[8] = "375 17 2255479";
        //arrTelVistovka[9] = "375 17 3212430";
        //arrTelVistovka[10] = "375 17 2932853";
        //arrTelVistovka[11] = "375 17 2374694";
        //arrTelVistovka[12] = "375 17 3983175";
        //arrTelVistovka[13] = "375 17 3274322";
        //arrTelVistovka[14] = "375 17 3277163";
        //
        //
        //String[] arrTypeEvent = new String[5];
        //arrTypeEvent[0] = "Кино";
        //arrTypeEvent[1] = "Концерты";
        //arrTypeEvent[2] = "Вечеринки";
        //arrTypeEvent[3] = "Спектакли";
        //arrTypeEvent[4] = "Выставки";
/*
        String[] arrNameEvent = new String[10];
        arrNameEvent[0] = "Вечеринка";
        arrNameEvent[1] = "Поэтический вечер";
        arrNameEvent[2] = "Показ премьеры";
        arrNameEvent[3] = "Музыкальный фестиваль";
        arrNameEvent[4] = "Рок-концерт";
        arrNameEvent[5] = "Лучшие спектакли";
        arrNameEvent[6] = "Вечер литературы";
        arrNameEvent[7] = "Студенческий вечер";
        arrNameEvent[8] = "Презентация нового альбома";
        arrNameEvent[9] = "Вечер кино";

        int num = 0;

        int[] arrAge = new int[5];
        arrAge[0] = 0;
        arrAge[1] = 3;
        arrAge[2] = 12;
        arrAge[3] = 16;
        arrAge[4] = 18;

        try {
            if (!file.exists()) { // проверяем, что если файл не существует, создаем его
                file.createNewFile();
            }
            try (PrintWriter printWriter = new PrintWriter(file.getAbsoluteFile())) {
                for (int i = 50000; i < 100000; i++) {
                    num = random.nextInt(5);
                    int tmp = arrAge[num];
                    printWriter.println(tmp + "\n");
                }
            }
        } catch (IOException ex) {
            throw new RuntimeException();
        }


        int minDay = (int) LocalDate.of(2016, 9, 1).toEpochDay();
        int maxDay = (int) LocalDate.of(2017, 9, 1).toEpochDay();

        try {
            if (!file.exists()) { // проверяем, что если файл не существует, создаем его
                file.createNewFile();
            }
            try (PrintWriter printWriter = new PrintWriter(file.getAbsoluteFile())) {
                for (int i = 0; i < 10000; i++) {
                    long randomDay = minDay + random.nextInt(maxDay - minDay);

                    LocalDate localDate = LocalDate.ofEpochDay(randomDay);

                    printWriter.println(localDate + "\n");
                }
            }
        } catch (IOException ex) {
            throw new RuntimeException();
        }*/

        String[] arrTopic = new String[7];
        arrTopic[0] = "Понравилось";
        arrTopic[1] = "Великолепно";
        arrTopic[2] = "Не очень";
        arrTopic[3] = "Скучно";
        arrTopic[4] = "Пойду еще";
        arrTopic[5] = "Рекомендую всем";
        arrTopic[6] = "Интересная задумка";

        String[] arrTextFeedback = new String[7];
        arrTextFeedback[0] = "Очень понравилось, все было на высоте";
        arrTextFeedback[1] = "Схожу еще раз, не плохо";
        arrTextFeedback[2] = "Скучно, зря потратил(а) время";
        arrTextFeedback[3] = "Ушел(а) раньше";
        arrTextFeedback[4] = "Буду рекомендовать друзьям";
        arrTextFeedback[5] = "Отличная задумка и реализаия";
        arrTextFeedback[6] = "На один раз, не очень";

        int tmp = 0;
        String s = "";
        try {
            if (!file.exists()) { // проверяем, что если файл не существует, создаем его
                file.createNewFile();
            }
            try (PrintWriter printWriter = new PrintWriter(file.getAbsoluteFile())) {
                for (int i = 0; i < 10000; i++) {
                    s = arrTextFeedback[random.nextInt(7)];
                    printWriter.println(s + "\n");
                }
            }
        } catch (IOException ex) {
            throw new RuntimeException();
        }
    }
}
