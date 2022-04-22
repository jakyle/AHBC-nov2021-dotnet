export interface Student {
    studentId: number;
    grade:     number;
    name:      string;
}

export type PostStudent = Omit<Student, "studentId">;