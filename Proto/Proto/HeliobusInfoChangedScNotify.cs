using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusInfoChangedScNotify : IMessage<HeliobusInfoChangedScNotify>, IMessage, IEquatable<HeliobusInfoChangedScNotify>, IDeepCloneable<HeliobusInfoChangedScNotify>, IBufferMessage
{
	private static readonly MessageParser<HeliobusInfoChangedScNotify> _parser = new MessageParser<HeliobusInfoChangedScNotify>(() => new HeliobusInfoChangedScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HPKHBLEJBIJFieldNumber = 1;

	private static readonly FieldCodec<DLFOGJGCCGP> _repeated_hPKHBLEJBIJ_codec = FieldCodec.ForMessage(10u, DLFOGJGCCGP.Parser);

	private readonly RepeatedField<DLFOGJGCCGP> hPKHBLEJBIJ_ = new RepeatedField<DLFOGJGCCGP>();

	public const int DKOGNOKOPKGFieldNumber = 6;

	private uint dKOGNOKOPKG_;

	public const int PhaseFieldNumber = 12;

	private uint phase_;

	public const int IMBOKGFIACAFieldNumber = 13;

	private uint iMBOKGFIACA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusInfoChangedScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusInfoChangedScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DLFOGJGCCGP> HPKHBLEJBIJ => hPKHBLEJBIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKOGNOKOPKG
	{
		get
		{
			return dKOGNOKOPKG_;
		}
		set
		{
			dKOGNOKOPKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Phase
	{
		get
		{
			return phase_;
		}
		set
		{
			phase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMBOKGFIACA
	{
		get
		{
			return iMBOKGFIACA_;
		}
		set
		{
			iMBOKGFIACA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusInfoChangedScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusInfoChangedScNotify(HeliobusInfoChangedScNotify other)
		: this()
	{
		hPKHBLEJBIJ_ = other.hPKHBLEJBIJ_.Clone();
		dKOGNOKOPKG_ = other.dKOGNOKOPKG_;
		phase_ = other.phase_;
		iMBOKGFIACA_ = other.iMBOKGFIACA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusInfoChangedScNotify Clone()
	{
		return new HeliobusInfoChangedScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusInfoChangedScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusInfoChangedScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hPKHBLEJBIJ_.Equals(other.hPKHBLEJBIJ_))
		{
			return false;
		}
		if (DKOGNOKOPKG != other.DKOGNOKOPKG)
		{
			return false;
		}
		if (Phase != other.Phase)
		{
			return false;
		}
		if (IMBOKGFIACA != other.IMBOKGFIACA)
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
		num ^= hPKHBLEJBIJ_.GetHashCode();
		if (DKOGNOKOPKG != 0)
		{
			num ^= DKOGNOKOPKG.GetHashCode();
		}
		if (Phase != 0)
		{
			num ^= Phase.GetHashCode();
		}
		if (IMBOKGFIACA != 0)
		{
			num ^= IMBOKGFIACA.GetHashCode();
		}
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
		hPKHBLEJBIJ_.WriteTo(ref output, _repeated_hPKHBLEJBIJ_codec);
		if (DKOGNOKOPKG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DKOGNOKOPKG);
		}
		if (Phase != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Phase);
		}
		if (IMBOKGFIACA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IMBOKGFIACA);
		}
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
		num += hPKHBLEJBIJ_.CalculateSize(_repeated_hPKHBLEJBIJ_codec);
		if (DKOGNOKOPKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKOGNOKOPKG);
		}
		if (Phase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Phase);
		}
		if (IMBOKGFIACA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMBOKGFIACA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusInfoChangedScNotify other)
	{
		if (other != null)
		{
			hPKHBLEJBIJ_.Add(other.hPKHBLEJBIJ_);
			if (other.DKOGNOKOPKG != 0)
			{
				DKOGNOKOPKG = other.DKOGNOKOPKG;
			}
			if (other.Phase != 0)
			{
				Phase = other.Phase;
			}
			if (other.IMBOKGFIACA != 0)
			{
				IMBOKGFIACA = other.IMBOKGFIACA;
			}
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
			case 10u:
				hPKHBLEJBIJ_.AddEntriesFrom(ref input, _repeated_hPKHBLEJBIJ_codec);
				break;
			case 48u:
				DKOGNOKOPKG = input.ReadUInt32();
				break;
			case 96u:
				Phase = input.ReadUInt32();
				break;
			case 104u:
				IMBOKGFIACA = input.ReadUInt32();
				break;
			}
		}
	}
}
