using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBenefitActivityInfo : IMessage<GetBenefitActivityInfo>, IMessage, IEquatable<GetBenefitActivityInfo>, IDeepCloneable<GetBenefitActivityInfo>, IBufferMessage
{
	private static readonly MessageParser<GetBenefitActivityInfo> _parser = new MessageParser<GetBenefitActivityInfo>(() => new GetBenefitActivityInfo());

	private UnknownFieldSet _unknownFields;

	public const int MKLDMAEAPPFFieldNumber = 3;

	private static readonly FieldCodec<BenefitData> _repeated_mKLDMAEAPPF_codec = FieldCodec.ForMessage(26u, BenefitData.Parser);

	private readonly RepeatedField<BenefitData> mKLDMAEAPPF_ = new RepeatedField<BenefitData>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int EHGBHCPKGJHFieldNumber = 12;

	private bool eHGBHCPKGJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBenefitActivityInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBenefitActivityInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BenefitData> MKLDMAEAPPF => mKLDMAEAPPF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EHGBHCPKGJH
	{
		get
		{
			return eHGBHCPKGJH_;
		}
		set
		{
			eHGBHCPKGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBenefitActivityInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBenefitActivityInfo(GetBenefitActivityInfo other)
		: this()
	{
		mKLDMAEAPPF_ = other.mKLDMAEAPPF_.Clone();
		retcode_ = other.retcode_;
		eHGBHCPKGJH_ = other.eHGBHCPKGJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBenefitActivityInfo Clone()
	{
		return new GetBenefitActivityInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBenefitActivityInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBenefitActivityInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mKLDMAEAPPF_.Equals(other.mKLDMAEAPPF_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EHGBHCPKGJH != other.EHGBHCPKGJH)
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
		num ^= mKLDMAEAPPF_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EHGBHCPKGJH)
		{
			num ^= EHGBHCPKGJH.GetHashCode();
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
		mKLDMAEAPPF_.WriteTo(ref output, _repeated_mKLDMAEAPPF_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (EHGBHCPKGJH)
		{
			output.WriteRawTag(96);
			output.WriteBool(EHGBHCPKGJH);
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
		num += mKLDMAEAPPF_.CalculateSize(_repeated_mKLDMAEAPPF_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EHGBHCPKGJH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBenefitActivityInfo other)
	{
		if (other != null)
		{
			mKLDMAEAPPF_.Add(other.mKLDMAEAPPF_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EHGBHCPKGJH)
			{
				EHGBHCPKGJH = other.EHGBHCPKGJH;
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
			case 26u:
				mKLDMAEAPPF_.AddEntriesFrom(ref input, _repeated_mKLDMAEAPPF_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				EHGBHCPKGJH = input.ReadBool();
				break;
			}
		}
	}
}
