using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ELEOGABGBKG : IMessage<ELEOGABGBKG>, IMessage, IEquatable<ELEOGABGBKG>, IDeepCloneable<ELEOGABGBKG>, IBufferMessage
{
	private static readonly MessageParser<ELEOGABGBKG> _parser = new MessageParser<ELEOGABGBKG>(() => new ELEOGABGBKG());

	private UnknownFieldSet _unknownFields;

	public const int DMEKIFJDKFLFieldNumber = 9;

	private uint dMEKIFJDKFL_;

	public const int CELFGCJFMPHFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_cELFGCJFMPH_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> cELFGCJFMPH_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ELEOGABGBKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ELEOGABGBKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMEKIFJDKFL
	{
		get
		{
			return dMEKIFJDKFL_;
		}
		set
		{
			dMEKIFJDKFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CELFGCJFMPH => cELFGCJFMPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELEOGABGBKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELEOGABGBKG(ELEOGABGBKG other)
		: this()
	{
		dMEKIFJDKFL_ = other.dMEKIFJDKFL_;
		cELFGCJFMPH_ = other.cELFGCJFMPH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELEOGABGBKG Clone()
	{
		return new ELEOGABGBKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ELEOGABGBKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ELEOGABGBKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMEKIFJDKFL != other.DMEKIFJDKFL)
		{
			return false;
		}
		if (!cELFGCJFMPH_.Equals(other.cELFGCJFMPH_))
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
		if (DMEKIFJDKFL != 0)
		{
			num ^= DMEKIFJDKFL.GetHashCode();
		}
		num ^= cELFGCJFMPH_.GetHashCode();
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
		if (DMEKIFJDKFL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DMEKIFJDKFL);
		}
		cELFGCJFMPH_.WriteTo(ref output, _repeated_cELFGCJFMPH_codec);
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
		if (DMEKIFJDKFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMEKIFJDKFL);
		}
		num += cELFGCJFMPH_.CalculateSize(_repeated_cELFGCJFMPH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ELEOGABGBKG other)
	{
		if (other != null)
		{
			if (other.DMEKIFJDKFL != 0)
			{
				DMEKIFJDKFL = other.DMEKIFJDKFL;
			}
			cELFGCJFMPH_.Add(other.cELFGCJFMPH_);
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
			case 72u:
				DMEKIFJDKFL = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				cELFGCJFMPH_.AddEntriesFrom(ref input, _repeated_cELFGCJFMPH_codec);
				break;
			}
		}
	}
}
