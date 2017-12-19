function getAllRacesUS() {
    $.ajax({
        type: "GET",
        headers: "*",
        methods: "*",
        url: "https://us.api.battle.net/wow/data/character/races?locale=en_US&apikey=6sunaaqxws2epqvznrwra26a5mtz6pf8",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var races = response.races;
            $('#output').empty();
            $('#output').append('<strong>All World of Warcraft Races for US Locals</strong>');
            $.each(races, function (index, race) {
                //returned json looks similiar to the below
                //id":1,"mask":1,"side":"alliance","name":"H
              
                $('#output').append('<table><tr>');
                $('#output').append('<td>id:' + race.id + '</td><td>mask:' + race.mask + '</td><td> Side: ' + race.side +'</td><td>name:' + race.name + '</td></tr>');
                $('#output').append('</table>');
            });
        },
        failure: function (msg) {
            $('#output').text(msg);
        }
    });
}

function getAllRacesEU() {
    $.ajax({
        type: "GET",
        headers: "*",
        methods: "*",
        url: "https://eu.api.battle.net/wow/data/character/races?locale=en_GB&apikey=6sunaaqxws2epqvznrwra26a5mtz6pf8",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var races = response.races;
            $('#output').empty();
            $('#output').append('<strong>All World of Warcraft Races for EU</strong>');
            $.each(races, function (index, race) {
                //returned json looks similiar to the below
                //id":1,"mask":1,"side":"alliance","name":"H
               
                $('#output').append('<table><tr>');
                $('#output').append('<td>id:' + race.id + '</td><td>mask:' + race.mask + '</td><td> Side: ' + race.side + '</td><td>name:' + race.name + '</td></tr>');
                $('#output').append('</table>');
            });
        },
        failure: function (msg) {
            $('#output').text(msg);
        }
    });
}

function getWoWAchievment() {
    $.ajax({
        type: "GET",
        headers: "*",
        methods: "*",
        url: "https://us.api.battle.net/wow/character/firetree/otissius?fields=stats&locale=en_US&apikey=6sunaaqxws2epqvznrwra26a5mtz6pf8",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var res = response;
            $('#output').empty();
            $('#output').append('<strong>Character Info</strong>');
            $('#output').append('<li>Character Name: '+res.name);
            $('#output').append('<li>Character Health: '+res.stats.health);
            //$.each(res, function (index, r) {
                //returned json looks similiar to the below
                //id":1,"mask":1,"side":"alliance","name":"H

             //   $('#output').append('<table><tr>');
             //   $('#output').append('<td>id:' + r.stats.health + '</td></tr>');
             //   $('#output').append('</table>');
            //});
        },
        failure: function (msg) {
            $('#output').text(msg);
        }
    });
}