using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameOrbInfo : IMessage<GridFightGameOrbInfo>, IMessage, IEquatable<GridFightGameOrbInfo>, IDeepCloneable<GridFightGameOrbInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameOrbInfo> _parser = new MessageParser<GridFightGameOrbInfo>(() => new GridFightGameOrbInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridGameOrb1ListFieldNumber = 10;

	private static readonly FieldCodec<GridGameOrbInfo1> _repeated_gridGameOrb1List_codec = FieldCodec.ForMessage(82u, GridGameOrbInfo1.Parser);

	private readonly RepeatedField<GridGameOrbInfo1> gridGameOrb1List_ = new RepeatedField<GridGameOrbInfo1>();

	public const int GridGameOrbListFieldNumber = 14;

	private static readonly FieldCodec<GridGameOrbInfo> _repeated_gridGameOrbList_codec = FieldCodec.ForMessage(114u, GridGameOrbInfo.Parser);

	private readonly RepeatedField<GridGameOrbInfo> gridGameOrbList_ = new RepeatedField<GridGameOrbInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameOrbInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameOrbInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameOrbInfo1> GridGameOrb1List => gridGameOrb1List_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameOrbInfo> GridGameOrbList => gridGameOrbList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameOrbInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameOrbInfo(GridFightGameOrbInfo other)
		: this()
	{
		gridGameOrb1List_ = other.gridGameOrb1List_.Clone();
		gridGameOrbList_ = other.gridGameOrbList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameOrbInfo Clone()
	{
		return new GridFightGameOrbInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameOrbInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameOrbInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridGameOrb1List_.Equals(other.gridGameOrb1List_))
		{
			return false;
		}
		if (!gridGameOrbList_.Equals(other.gridGameOrbList_))
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
		num ^= gridGameOrb1List_.GetHashCode();
		num ^= gridGameOrbList_.GetHashCode();
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
		gridGameOrb1List_.WriteTo(ref output, _repeated_gridGameOrb1List_codec);
		gridGameOrbList_.WriteTo(ref output, _repeated_gridGameOrbList_codec);
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
		num += gridGameOrb1List_.CalculateSize(_repeated_gridGameOrb1List_codec);
		num += gridGameOrbList_.CalculateSize(_repeated_gridGameOrbList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameOrbInfo other)
	{
		if (other != null)
		{
			gridGameOrb1List_.Add(other.gridGameOrb1List_);
			gridGameOrbList_.Add(other.gridGameOrbList_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 82u:
				gridGameOrb1List_.AddEntriesFrom(ref input, _repeated_gridGameOrb1List_codec);
				break;
			case 114u:
				gridGameOrbList_.AddEntriesFrom(ref input, _repeated_gridGameOrbList_codec);
				break;
			}
		}
	}
}
