function getAllRacesUS() {
    $.ajax({
        type: "GET",
        headers: "*",
        methods: "*",
        url: "http://us.battle.net/api/wow/data/character/races?locale=en_US",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var races = response.races;
            $('#output').empty();
            $('#output').append('<strong>All World of Warcraft Races for US Locals</strong>')
            $.each(races, function (index, race) {
                //returned json looks similiar to the below
                //id":1,"mask":1,"side":"alliance","name":"H
              
                $('#output').append('<table><tr>')
                $('#output').append('<td>id:' + race.id + '</td><td>mask:' + race.mask + '</td><td> Side: ' + race.side +'</td><td>name:' + race.name + '</td></tr>');
                $('#output').append('</table>')
            });
        },
        failure: function (msg) {
            $('#output').text(msg);
        }
    });
}

function getAllRacesEUGreatBritian() {
    $.ajax({
        type: "GET",
        headers: "*",
        methods: "*",
        url: "http://eu.battle.net/api/wow/data/character/races?locale=en_GB",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var races = response.races;
            $('#output').empty();
            $('#output').append('<strong>All World of Warcraft Races for Great Britian</strong>')
            $.each(races, function (index, race) {
                //returned json looks similiar to the below
                //id":1,"mask":1,"side":"alliance","name":"H
               
                $('#output').append('<table><tr>')
                $('#output').append('<td>id:' + race.id + '</td><td>mask:' + race.mask + '</td><td> Side: ' + race.side + '</td><td>name:' + race.name + '</td></tr>');
                $('#output').append('</table>')
            });
        },
        failure: function (msg) {
            $('#output').text(msg);
        }
    });
}