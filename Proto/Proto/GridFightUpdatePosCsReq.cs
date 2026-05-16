using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUpdatePosCsReq : IMessage<GridFightUpdatePosCsReq>, IMessage, IEquatable<GridFightUpdatePosCsReq>, IDeepCloneable<GridFightUpdatePosCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightUpdatePosCsReq> _parser = new MessageParser<GridFightUpdatePosCsReq>(() => new GridFightUpdatePosCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GridFightPosInfoListFieldNumber = 10;

	private static readonly FieldCodec<GridFightPosInfo> _repeated_gridFightPosInfoList_codec = FieldCodec.ForMessage(82u, GridFightPosInfo.Parser);

	private readonly RepeatedField<GridFightPosInfo> gridFightPosInfoList_ = new RepeatedField<GridFightPosInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUpdatePosCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUpdatePosCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightPosInfo> GridFightPosInfoList => gridFightPosInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosCsReq(GridFightUpdatePosCsReq other)
		: this()
	{
		gridFightPosInfoList_ = other.gridFightPosInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosCsReq Clone()
	{
		return new GridFightUpdatePosCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUpdatePosCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUpdatePosCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightPosInfoList_.Equals(other.gridFightPosInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= gridFightPosInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		gridFightPosInfoList_.WriteTo(ref output, _repeated_gridFightPosInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += gridFightPosInfoList_.CalculateSize(_repeated_gridFightPosInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUpdatePosCsReq other)
	{
		if (other != null)
		{
			gridFightPosInfoList_.Add(other.gridFightPosInfoList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gridFightPosInfoList_.AddEntriesFrom(ref input, _repeated_gridFightPosInfoList_codec);
			}
		}
	}
}
