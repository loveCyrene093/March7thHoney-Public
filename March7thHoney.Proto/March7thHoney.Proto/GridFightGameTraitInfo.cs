using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameTraitInfo : IMessage<GridFightGameTraitInfo>, IMessage, IEquatable<GridFightGameTraitInfo>, IDeepCloneable<GridFightGameTraitInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameTraitInfo> _parser = new MessageParser<GridFightGameTraitInfo>(() => new GridFightGameTraitInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightTraitInfoFieldNumber = 5;

	private static readonly FieldCodec<GridGameTraitInfo> _repeated_gridFightTraitInfo_codec = FieldCodec.ForMessage(42u, GridGameTraitInfo.Parser);

	private readonly RepeatedField<GridGameTraitInfo> gridFightTraitInfo_ = new RepeatedField<GridGameTraitInfo>();

	public const int ALIDDLBDPDHFieldNumber = 13;

	private static readonly FieldCodec<ELEOGABGBKG> _repeated_aLIDDLBDPDH_codec = FieldCodec.ForMessage(106u, ELEOGABGBKG.Parser);

	private readonly RepeatedField<ELEOGABGBKG> aLIDDLBDPDH_ = new RepeatedField<ELEOGABGBKG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameTraitInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameTraitInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridGameTraitInfo> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ELEOGABGBKG> ALIDDLBDPDH => aLIDDLBDPDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitInfo(GridFightGameTraitInfo other)
		: this()
	{
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		aLIDDLBDPDH_ = other.aLIDDLBDPDH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameTraitInfo Clone()
	{
		return new GridFightGameTraitInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameTraitInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameTraitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!aLIDDLBDPDH_.Equals(other.aLIDDLBDPDH_))
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
		num ^= gridFightTraitInfo_.GetHashCode();
		num ^= aLIDDLBDPDH_.GetHashCode();
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
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		aLIDDLBDPDH_.WriteTo(ref output, _repeated_aLIDDLBDPDH_codec);
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
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		num += aLIDDLBDPDH_.CalculateSize(_repeated_aLIDDLBDPDH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameTraitInfo other)
	{
		if (other != null)
		{
			gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
			aLIDDLBDPDH_.Add(other.aLIDDLBDPDH_);
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
			case 42u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 106u:
				aLIDDLBDPDH_.AddEntriesFrom(ref input, _repeated_aLIDDLBDPDH_codec);
				break;
			}
		}
	}
}
