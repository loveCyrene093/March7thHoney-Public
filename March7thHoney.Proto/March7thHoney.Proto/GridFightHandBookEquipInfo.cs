using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookEquipInfo : IMessage<GridFightHandBookEquipInfo>, IMessage, IEquatable<GridFightHandBookEquipInfo>, IDeepCloneable<GridFightHandBookEquipInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookEquipInfo> _parser = new MessageParser<GridFightHandBookEquipInfo>(() => new GridFightHandBookEquipInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightItemListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_gridFightItemList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> gridFightItemList_ = new RepeatedField<uint>();

	public const int NAPBAFFAGBHFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_nAPBAFFAGBH_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> nAPBAFFAGBH_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookEquipInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookEquipInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightItemList => gridFightItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NAPBAFFAGBH => nAPBAFFAGBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookEquipInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookEquipInfo(GridFightHandBookEquipInfo other)
		: this()
	{
		gridFightItemList_ = other.gridFightItemList_.Clone();
		nAPBAFFAGBH_ = other.nAPBAFFAGBH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookEquipInfo Clone()
	{
		return new GridFightHandBookEquipInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookEquipInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookEquipInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightItemList_.Equals(other.gridFightItemList_))
		{
			return false;
		}
		if (!nAPBAFFAGBH_.Equals(other.nAPBAFFAGBH_))
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
		num ^= gridFightItemList_.GetHashCode();
		num ^= nAPBAFFAGBH_.GetHashCode();
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
		gridFightItemList_.WriteTo(ref output, _repeated_gridFightItemList_codec);
		nAPBAFFAGBH_.WriteTo(ref output, _repeated_nAPBAFFAGBH_codec);
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
		num += gridFightItemList_.CalculateSize(_repeated_gridFightItemList_codec);
		num += nAPBAFFAGBH_.CalculateSize(_repeated_nAPBAFFAGBH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookEquipInfo other)
	{
		if (other != null)
		{
			gridFightItemList_.Add(other.gridFightItemList_);
			nAPBAFFAGBH_.Add(other.nAPBAFFAGBH_);
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
			case 8u:
			case 10u:
				gridFightItemList_.AddEntriesFrom(ref input, _repeated_gridFightItemList_codec);
				break;
			case 72u:
			case 74u:
				nAPBAFFAGBH_.AddEntriesFrom(ref input, _repeated_nAPBAFFAGBH_codec);
				break;
			}
		}
	}
}
