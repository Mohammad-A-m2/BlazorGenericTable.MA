using BlazorGenericTable.MA.Models.Elements;
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

        private TableClass _tableClass = new()
        {
            TableBaseClass = "my-base-class",
            TrRowsClass = "my-tr-class",
            ThHeaderClass = "my-th-class",
            TdRowsClass = "my-td-class",
            DeleteButtonClass = "btn btn-outline-danger",
            SelectBoxClass = string.Empty,
            DeleteIconClass= "fa fa-trash"
        };
        private TableStyle _tableStyle = new()
        {
            TableBaseStyle = "width:100%; border-collapse: collapse; margin-bottom: 20px;",
            //TrRowStyle = "background-color: #f9f9f9;  // it added by CSS",
            ThHeaderStyle = "padding: 12px; border: 1px solid #ddd; text-align: left; background-color: #f4f4f4;",
            TdRowStyle = "padding: 12px; border: 1px solid #ddd; text-align: left;",
            DeleteButtonStyle = "text-decoration-line: underline;"
        };

        private PaginationSetting _paginationSetting = new();

        protected override void OnInitialized()
        {
            Dictionary<string, object> checkboxAttributes = new()
            {
                { "ID", "object Test" }
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
                    HeaderToolTip="Test tooltip header",
                    RowToolTip ="Test tooltip row",
                    CheckboxAttributes = checkboxAttributes,
                    IsHeaderDisabled = false
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
                PageSizeOptions = [2,4, 5, 10, 20, 50, 100],
                PageSizeStyle = "test;"
            };
        }

        string _deleteText = string.Empty;
        private void OnDeleteClick(Person person)
        {
            _deleteText = "You have deleted a " + person.Name;
            _people = _people.Where(c => !c.Equals(person)).ToList(); // Reassign list
            _paginationSetting.TotalCount = _people.Count;
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
            return await Task.FromResult(_people.Skip((pageNumber - 1) * _paginationSetting.PageSize)
                .Take(_paginationSetting.PageSize).ToList());
        } 

        private void PageSizeChanged(int pageSizeNumber)
        {
            _paginationClick = "Page size changed to " + pageSizeNumber;
        }
    }
}
