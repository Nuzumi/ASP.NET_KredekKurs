$(document).ready(function (e) {
    
    $('a').click(function (e) {
        e.preventDefault()
        $(this).tab('show')
    });

    var wedkiList = [{
        'name': 'wedka ta drozsza', 'des': 'jak ktos sie na tym zna to wie ze duzo kosztuje', 'price': '6000$', 'id': '1'
    }, {
        'name': 'wedka ze sredniej polki', 'des': 'wydaje sie drozsza niz jest', 'price': '2500$', 'id': '2'
    }, {
        'name': 'wedka najtansza', 'des': 'najlepsza do lowienia ryb (wyglada na tania)', 'price': '100$', 'id': '3'
    }];

    var splawikiList = [{
        'name': 'splawik ten drozszy', 'des': 'ladny, mozna wybrac kolor', 'price': '500$', 'id': '4'
    }, {
        'name': 'splawik ze sredniej polki', 'des': 'troche mniej ladny ale dalej kolorowy', 'price': '250$', 'id': '5'
    }, {
        'name': 'najtanszy splawik', 'des': 'taki normalny', 'price': '10$', 'id': '6'
    }
    ];

    var koszyk = [];

    var zakladki = [{
        'title': 'splawiki' , 'id': '1', 'messages':splawikiList
    }, {
        'title': 'wedki', 'id': '2', 'messages': wedkiList
    }];

    function initialize() {
        renderItemList(wedkiList);
        $.each(zakladki, (key, value) => {
            var poLewej = $('#poLewej').clone();
            console.log(value);
            poLewej.text(value.title);
            poLewej.attr('id', 'zakladki-' + value.id);
            poLewej.css('display', '');
            poLewej.on('click', (e) => {
                e.preventDefault();
                $('[id^=msg-]').remove();
                var zakladkiId = $('#zakladki-' + value.id).attr('id').substring(9);
                var searchedZakladki = zakladki.find(zakladka =>zakladka.id === zakladkiId).messages;
                console.log(zakladkiId);
                console.log($(this));
                renderItemList(searchedZakladki);
            });
            $('#poLewej').after(poLewej);
        })

    }

    initialize();


    function renderItemList(messages) {
        console.log('render');
        $.each(messages, function (key, valu) {
            addNewItem(valu);
        });
    }

    
    function addNewItem(item) {
        var list = $('#items').clone();
        list.find('.NazwaW').text(item.name);
        console.log(item.name);
        list.find('.price').text(item.price);
        list.attr('id', 'msg-' + item.id);
        list.find('.des').text(item.des);
        list.css('display', '');
        $('#lista li:last').after(list);
    }


    $('.toBuyMore').click(function (e) {
        var itemA = $(this).children();
        var purchase = {
            name: $(itemA).find('.NazwaW').text(),
            des: itemA.find('.des').text(),
            price: itemA.find('.price').text()
        };
        koszyk.push(purchase);
        console.log("do koszyka");
    });

    $('.koszyk').click(function (e) {
        $.each(koszyk, function (key, valu) {
            console.log('i');
            addNewItemToCart(valu);
        });
    });

    function addNewItemToCart(item) {
        var list = $('#cartItem').clone();
        list.find('.NazwaW').text(item.name);
        list.find('.price').text(item.price);
        list.find('.des').text(item.des);
        list.css('display', '');
        $('#koszyk li:last').after(list);
    }

    $('#buy').click(function (e) {
        $('#shopCart').empty();
        $('#thisIsTheEnd').modal('show');
    });

    

});