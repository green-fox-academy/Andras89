/**
 * Created by aze on 2017.05.09..
 */
window.baseUrl = "http://localhost:12345/api";
$("#server_change").on("submit", function (e) {
    e.preventDefault();
    window.baseUrl = $("#server_address").val();
    console.log(window.baseUrl);
});
handle = function handle(id, info, where, data) {
    if (data) {
        console.log(where + " " + info);
        console.log(data);
    }
    $(id).append("<li>" + info + (data ? " - check the console for the response " : "") + "</li>");
}
$("#doubling").on("click", function () {
    $.get(window.baseUrl + "/doubling", {}).done(function (data) {
        if ("error" in data && data["error"] == "Please provide an input!") {
            handle("#doubling_response", "OK - without data");
        } else {
            handle("#doubling_response", "not ok - without data", "Doubling", data);
        }
    }).error(function (err) {
        handle("#doubling_response", "not ok - without data", "Doubling", err);
    });
    $.get(window.baseUrl + "/doubling", { input: 5 }).done(function (data) {
        if ("received" in data && "result" in data && data["received"] == 5 && data["result"] == 10) {
            handle("#doubling_response", "OK - with input=5");
        } else {
            handle("#doubling_response", "not ok - with input=5", "Doubling", data);
        }
    }).error(function (err) {
        handle("#doubling_response", "not ok - with input=5", "Doubling", err);
    });
});

$("#greeter").on("click", function () {
    $.get(window.baseUrl + "/greeter", {}).done(function (data) {
        if ("error" in data && data["error"] == "Please provide a name!") {
            handle("#greeter_response", "OK - without name");
        } else {
            handle("#greeter_response", "not ok - without name", "Greeter", data);
        }
    }).error(function (err) {
        handle("#greeter_response", "not ok - without name", "Greeter", err);
    });
    $.get(window.baseUrl + "/greeter", { name: "petike" }).done(function (data) {
        if ("error" in data && data["error"] == "Please provide a title!") {
            handle("#greeter_response", "OK - without title");
        } else {
            handle("#greeter_response", "not ok - without title", "Greeter", data);
        }
    }).error(function (err) {
        handle("#greeter_response", "not ok - without title", "Greeter", err);
    });
    $.get(window.baseUrl + "/greeter", { name: "petike", title: "student" }).done(function (data) {
        if ("welcome_message" in data && data["welcome_message"] == "Oh, hi there petike, my dear student!") {
            handle("#greeter_response", "OK - with petike and student");
        } else {
            handle("#greeter_response", "not ok - with petike and student", "Greeter", data);
        }
    }).error(function (err) {
        handle("#greeter_response", "not ok - with petike and student", "Greeter", err);
    });
});

$("#appenda").on("click", function () {
    $.get(window.baseUrl + "/appenda", {}).done(function (data) {
        handle("#appenda_response", "not ok - without appendable", "Appenda", data);
    }).error(function (err) {
        handle("#appenda_response", "OK - without appendable");
    });
    $.get(window.baseUrl + "/appenda/kuty", {}).done(function (data) {
        if ("appended" in data && data["appended"] == "kutya") {
            handle("#appenda_response", "OK - with /kuty");
        } else {
            handle("#appenda_response", "not ok - with /kuty", "Appenda", data);
        }
    }).error(function (err) {
        handle("#appenda_response", "not ok - with /kuty", "Appenda", err);
    });
});

$("#dountil").on("click", function () {
    $.post(window.baseUrl + "/dountil", { until: 5 }).done(function (data) {
        handle("#dountil_response", "not ok - without what", "Dountil", data);
    }).error(function (err) {
        handle("#dountil_response", "OK - without what");
    });
    $.post(window.baseUrl + "/dountil/sum", {}).done(function (data) {
        if ("error" in data && data["error"] == "Please provide a number!") {
            handle("#dountil_response", "OK - without number");
        } else {
            handle("#dountil_response", "not ok - without number", "Dountil", data);
        }
    }).error(function (err) {
        handle("#dountil_response", "not ok - without number", "Dountil", err);
    });
    $.post({ url: window.baseUrl + "/dountil/sum", data: JSON.stringify({ until: 7 }), contentType: 'application/json; charset=utf-8' }).done(function (data) {
        if ("result" in data && data["result"] == 28) {
            handle("#dountil_response", "OK - with /sum until=7");
        } else {
            handle("#dountil_response", "not ok - with /sum until=7", "Dountil", data);
        }
    }).error(function (err) {
        handle("#dountil_response", "not ok - with /sum until=7", "Dountil", err);
    });
    $.post({ url: window.baseUrl + "/dountil/factor", data: JSON.stringify({ until: 4 }), contentType: 'application/json; charset=utf-8' }).done(function (data) {
        if ("result" in data && data["result"] == 24) {
            handle("#dountil_response", "OK - with /factor until=4");
        } else {
            handle("#dountil_response", "not ok - with /factor until=4", "Dountil", data);
        }
    }).error(function (err) {
        handle("#dountil_response", "not ok - with /factor until=4", "Dountil", err);
    });
});