import {ClrDatagridComparatorInterface} from "@clr/angular";

export class ClrDataGridComparator implements ClrDatagridComparatorInterface<any> {
    compare(a: any, b: any) {
      console.log(a,b)
        return a.key - b.key;
    }
}


