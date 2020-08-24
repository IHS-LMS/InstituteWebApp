var script = document.createElement('script');
script.src = 'https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.5.1.js';
script.type = 'text/javascript';
document.getElementsByTagName('head')[0].appendChild(script);

        $(function () {
            $('.button-style').click(function () {

                var course = {
                    CourseName: $(".CourseName").val(),
                    TeacherName: $(".TeacherName").val(),
                    Department: $(".Department").val()
                }

                $.ajax({
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(course),
                    url: "/Faculty/Course",
                    success: function (data) {
                        alert("Data: " + data);
                    },
                    error: function (result) {
                        alert("Problem occured" + result);
                    }
                });
            })
    });