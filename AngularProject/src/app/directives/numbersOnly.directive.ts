import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[numbersOnly]'
})
export class NumbersOnlyDirective {

  constructor(private _element: ElementRef) { }

  @HostListener('input', ['$event']) onInputChange(event) {
    const initalValue = this._element.nativeElement.value;

    this._element.nativeElement.value = initalValue.replace(/[^0-9]*/g, '');
    if ( initalValue !== this._element.nativeElement.value) {
      event.stopPropagation();
    }
  }
}