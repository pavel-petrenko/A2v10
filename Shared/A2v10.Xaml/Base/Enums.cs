﻿
// Copyright © 2015-2017 Alex Kukhtin. All rights reserved.

namespace A2v10.Xaml
{
    public enum TextAlign
    {
        Default = 0,
        Left = Default,
        Right,
        Center
    }

    public enum VerticalAlign
    {
        Default,
        Top,
        Middle,
        Bottom
    }

    public enum GridLinesVisibility {
        None,
        Horizontal,
        Vertical,
        Both
    }

    public enum Orientation
    {
        Vertical,
        Horizontal
    }

    public enum DataType
    {
        String, 
        Date,
        DateTime,
        Time,
        Number,
        Currency,
        Boolean
    }

    public enum ControlSize
    {
        Default = 0,
        Large = 1,
        Medium = Default,
        Small = 2,
        Mini = 3
    };

    public enum TextSize
    {
        Normal,
        Small
    }

    public enum WrapMode
    {
        Default,
        Wrap,
        NoWrap,
        PreWrap
    }

    public enum AutoSelectMode
    {
        None,
        FirstItem
    }

    public enum Icon
    {
        NoIcon = 0,
        Access,
        Add,
        Alert,
        Approve,
        ArrowDown,
        ArrowLeft,
        ArrowRight,
        ArrowUp,
        ArrowExport,
        ArrowOpen,
        ArrowSort,
        Attach,
        Ban,
        Calendar,
        ChartArea,
        ChartBar,
        ChartColumn,
        ChartPie,
        ChartPivot,
        ChartStackedArea,
        ChartStackedBar,
        ChevronDown,
        ChevronLeft,
        ChevronLeftEnd,
        ChevronRight,
        ChevronRightEnd,
        ChevronUp,
        Clear,
        Close,
        Cloud,
        CloudOutline,
        Comment,
        CommentAdd,
        CommentDiscussion,
        CommentLines,
        CommentNext,
        CommentOutline,
        CommentPrevious,
        CommentUrgent,
        Copy,
        Cut,
        Delete,
        DeleteBox,
        Dashboard,
        DashboardOutline,
        Database,
        Disapprove,
        Dot,
        DotBlue,
        DotGreen,
        DotRed,
        Download,
        Edit,
        Ellipsis,
        EllipsisVertical,
        Error,
        ErrorOutline,
        Exit,
        Eye,
        Flag,
        File,
        FileContent,
        FileImage,
        FilePreview,
        Filter,
        FilterOutline,
        Folder,
        Gear,
        GearOutline,
        Grid,
        Help,
        HelpBlue,
        HelpOutline,
        History,
        Info,
        InfoBlue,
        InfoOutline,
        Image,
        Link,
        List,
        Lock,
        LockOutline,
        Log,
        Menu,
        Message,
        MessageOutline,
        Minus,
        MinusBox,
        MinusCircle,
        Package,
        PackageOutline,
        Paste,
        Pencil,
        PencilOutline,
        Pin,
        PinOutline,
        Pinned,
        PinnedOutline,
        Plus,
        PlusBox,
        PlusCircle,
        Policy,
        Power,
        Print,
        Process,
        Queue,
        Refresh,
        Reload,
        Rename,
        Requery,
        Save,
        SaveClose,
        Search,
        Server,
        Share,
        Square,
        Star,
        StarOutline,
        StarYellow,
        Step,
        Steps,
        Storyboard,
        Success,
        SuccessOutline,
        Switch,
        Table,
        Tag,
        TagBlue,
        TagGreen,
        TagOutline,
        TagRed,
        TagYellow,
        Trash,
        TriangleLeft,
        TriangleRight,
        Unlock,
        UnlockOutline,
        Unpin,
        UnpinOutline,
        Upload,
        User,
        Users,
        Waiting,
        Warning,
        WarningOutline,
        Wrench
    }
}
