   $(document).ready(function () {
            $('#calendarAug').fullCalendar('destroy');
            $('#calendarSep').fullCalendar('destroy');
            $('#calendarOct').fullCalendar('destroy');
            $('#calendarNov').fullCalendar('destroy');

            // const calOctorber = {
                //     calendarMonth='calendarOct'
                //     firstDay: '2024-10-01'
                // }
                // const calNovember = {
                //     calendarMonth='calendarNov'
                //     lastName: "2024-11-01"
                // }
                calendarReady.genarateCalendar.call('#calendarOct')
            

            $('#calendarAug').fullCalendar({
                contentHeight: 250,
            defaultDate: '2024-08-01',
            timeFormat: 'h(:mm)a',
            header: {
                left: '',
            center: 'title',
            right: ''
                },
            eventLimit: true,
            eventColor: '#378006',
            selectable: true,
            editable: true,
                
            })
            $('#calendarSep').fullCalendar({
                contentHeight: 250,
            defaultDate:'2024-09-01',
            timeFormat: 'h(:mm)a',
            header: {
                left: '',
            center: 'title',
            right: ''
                },
            eventLimit: true,
            eventColor: '#378006',
            selectable: true,
            editable: true,

            })
        })
            const calendarReady = {
                genarateCalendar: function (control) {
                $('#calendarOct').fullCalendar({
                    contentHeight: 250,
                    defaultDate: '2024-10-01',
                    timeFormat: 'h(:mm)a',
                    header: {
                        left: '',
                        center: 'title',
                        right: ''
                    },
                    eventLimit: true,
                    eventColor: '#378006',
                    selectable: true,
                    editable: true,

                })
                $('#calendarNov').fullCalendar({
                contentHeight: 250,
            defaultDate: '2024-11-01',
            timeFormat: 'h(:mm)a',
            header: {
                left: '',
            center: 'title',
            right: ''
                    },
            eventLimit: true,
            eventColor: '#378006',
            selectable: true,
            editable: true,

                })
            }
        }
       
