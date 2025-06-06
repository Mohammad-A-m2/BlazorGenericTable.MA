﻿using BlazorGenericTable.MA.Models.Elements;
using BlazorGenericTable.MA.UseCase.Client.Models;
using BlazorGenericTable.MA.UseCase.Client.Models.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorGenericTable.MA.UseCase.Client.Pages
{
    public partial class TableCreatorComponent : ComponentBase
    {
        private List<Person> _people = PersonMockData.GetPersons();
        private TableSettings _tableSettings = new();
        private string _paginationClick = string.Empty;
        private LoadingBarSettings _LoadingBarSettings = new();

        private TableClass _tableClass = new()
        {
            TableBaseClass = "my-base-class styled-table",
            TrRowsClass = "my-tr-class",
            ThHeaderClass = "my-th-class",
            TdRowsClass = "my-td-class",
            OperationButtonsClass = new()
            {
                ViewButtonClass = "btn btn-outline-primary",
                ViewButtonIconClass = "fa fa-eye",
                DeleteButtonClass = "btn btn-outline-danger",
                DeleteButtonIconClass = "fa fa-trash",
                EditButtonClass = "btn btn-outline-primary",
                EditButtonIconClass = "fa fa-pencil-square-o ",
            },
            SelectBoxClass = string.Empty,
        };
        private TableStyle _tableStyle = new()
        {
            // Most of the style has been added in css file.
            // you can also add below style in css file too.        
            TrHeaderStyle = "background: linear-gradient(90deg, #4F72A3, #56A3DC);" +
            " color: #ffffff; text-align: left; font-weight: bold;",
            ThHeaderStyle = "padding: 12px 15px;",
            TdRowStyle = "border-bottom: 1px solid #dddddd; padding: 2px;",
            OperationButtonsStyle = new()
            {
                ViewButtonIconStyle = "text-decoration-line: underline;",
                ViewButtonStyle = "test style view",
                DeleteButtonIconStyle = "text-decoration-line: underline;",
                DeleteButtonStyle = "test style delete",
                EditButtonIconStyle = "text-decoration-line: underline;",
                EditButtonStyle = "test edit style"
            },
        };

        private PaginationSetting? _paginationSetting = new();

        protected override void OnInitialized()
        {
            Dictionary<string, object> checkboxAttributes = new()
            {
                 { "ID", Guid.NewGuid().ToString() }
            };
            _tableSettings = new()
            {
                TableStyle = _tableStyle,
                TableClass = _tableClass,
                ColSetting = new TableColGroup()
                {
                    ColSpan = new Dictionary<uint, string>
                    {
                        {1, "border-bottom: 1px solid #ddd;border-left: 1px solid #ddd;background-color: #f9f9f9; color:white; font-weight:bold" },
                        {2, "border-bottom: 1px solid #ddd;background-color: #f9f9f9; color:white; font-weight:bold" },
                        {3, "border-bottom: 1px solid #ddd;background-color: #f9f9f9; color:white; font-weight:bold" },
                        {4, "border-bottom: 1px solid #ddd;border-right: 1px solid #ddd;background-color: #f9f9f9; color:white; font-weight:bold" }
                    }
                },
                CheckboxParameters = new()
                {
                    HeaderToolTip = "Test tooltip header",
                    RowToolTip = "Test tooltip row",
                    CheckboxAttributes = checkboxAttributes,
                    IsHeaderDisabled = false
                },
                DeleteDialogModel = new()
                {
                    DialogText = "Are you sure to remove the row?", //if it's not added it would be added a text by default
                    Class = "test class dialog",
                    Style = "test style dialog",
                    SubmitText = "Remove", //if it's not added it would be added a text by default
                    CancelText = "Cancel" //if it's not added it would be added a text by default
                }
            };
            _paginationSetting = new()
            {
                AriaLable = "Page navigation",
                UlClass = "pagination",
                UlStyle = "background-color:#f9f9f9;",
                FirstButtonStyle = "background-color:#f9f9f9;",
                BackwardButtonStyle = "background-color:#f9f9f9;",
                NavigationButtonsStyle = "background-color:#86b7fe;",
                ForwardButtonStyle = "background-color:#f9f9f9;",
                LastButtonStyle = "background-color:#f9f9f9;",
                PageSize = 2,
                TotalCount = PersonMockData.GetPersons().Count,
                PageSizeOptions = [2, 4, 5, 10, 20, 50, 100],
                PageSizeStyle = "test;"
            };
            _LoadingBarSettings = new()
            {
                HasLoading = true,
                ProgressClass = "test",
                ProgressStyle = "test style loading",
                WrapperClass = "Wrapper clas test",
                WrapperStyle = "Wrapper style test",
                ProgressBarLoadingText = "Loading data please wait...",
                SpinnerLoadingText = "Loading..."
            };
        }

        string _deleteText = string.Empty;
        private void OnDeleteClick(Person person)
        {
            _deleteText = "You have deleted a " + person.Name;
            _people = _people.Where(c => !c.Equals(person)).ToList(); // Reassign list
            if (_paginationSetting is not null)
            {
                _paginationSetting.TotalCount = _people.Count;
            }
            StateHasChanged();
        }

        List<Person> _selectedItems = new();
        private void IsRowsCheckBoxChanged(List<Person> persons)
        {
            if (persons.Count > 0)
            {
                _selectedItems = persons;
            }
            else
            {
                _selectedItems.Clear();
            }
        }

        List<Person> _selectedHeaderItems = new();
        private void IsHeaderCheckBoxChanged(List<Person> persons)
        {
            if (persons.Count > 0)
            {
                _selectedHeaderItems = persons;
            }
            else
            {
                _selectedHeaderItems = new();
            }
        }

        private void BackwardClick()
        {
            _paginationClick = "Backward clicked";
        }

        private void ForwardClick()
        {
            _paginationClick = "Forward clicked";
        }

        private void NavigationClick(int pageNumber)
        {
            _paginationClick = "Navigation clicked on page" + pageNumber;
        }

        private void LastPageClick()
        {
            _paginationClick = "Last Page clicked";
        }

        private void FirstPageClick()
        {
            _paginationClick = "First Page clicked";
        }

        private async Task<ICollection<Person>> GetPeopleByPageNumber(int pageNumber)
        {
            await Task.Delay(2000);
            if (_paginationSetting is not null)
            {
                return await Task.FromResult(_people.Skip((pageNumber - 1) * _paginationSetting.PageSize)
                    .Take(_paginationSetting.PageSize).ToList());
            }
            return await Task.FromResult(_people);
        }

        private void PageSizeChanged(int pageSizeNumber)
        {
            _paginationClick = "Page size changed to " + pageSizeNumber;
        }

        private void OpenViewPage(Person person)
        {
            //Open your view page
            Console.WriteLine("View=>" + person.Name);
        }

        private void OpenEditPage(Person person)
        {
            //Open your edit page
            Console.WriteLine("Edit=>" + person.Name);
        }
    }
}
