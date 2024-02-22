# WPF Kiosk
## 이벤트 바인딩 절차
1. CustomControl 구현
2. ICommand 바인딩 속성(DependencyProperty) 추가
3. Selection 이벤트 구현
4. ICommand Execute
5. 뷰모델에서 ICommand 속성 생성
6. RelayCommand를 생성하여 콜백 메소드 구현
7. 뷰를 통한 SelectionCommand 바인딩