
        $(document).ready(function () {
            $("#filetable").DataTable({
                "order": [[2, "desc"]],
                "language": {
                    "sEmptyTable": "Tabulka neobsahuje ��dn� data",
                    "sInfo": "Zobrazuji _START_ a� _END_ z celkem _TOTAL_ z�znam�",
                    "sInfoEmpty": "Zobrazuji 0 a� 0 z 0 z�znam�",
                    "sInfoFiltered": "(filtrov�no z celkem _MAX_ z�znam�)",
                    "sInfoPostFix": "",
                    "sInfoThousands": " ",
                    "sLengthMenu": "Zobraz z�znam� _MENU_",
                    "sLoadingRecords": "Na��t�m...",
                    "sProcessing": "Prov�d�m...",
                    "sSearch": "Hledat:",
                    "sZeroRecords": "��dn� z�znamy nebyly nalezeny",
                    "oPaginate": {
                        "sFirst": "Prvn�",
                        "sLast": "Posledn�",
                        "sNext": "Dal��",
                        "sPrevious": "P�edchoz�"
                    },
                    "oAria": {
                        "sSortAscending": ": aktivujte pro �azen� sloupce vzestupn�",
                        "sSortDescending": ": aktivujte pro �azen� sloupce sestupn�"
                    }
                }
            });
        });