export interface SearchResult {
    id : Int16Array;
    createTime: Date;
    searchPhrase: string;
    matchUrl: string;
    ranks: string;
}