using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeBenefitActivityRewardCsReq : IMessage<TakeBenefitActivityRewardCsReq>, IMessage, IEquatable<TakeBenefitActivityRewardCsReq>, IDeepCloneable<TakeBenefitActivityRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeBenefitActivityRewardCsReq> _parser = new MessageParser<TakeBenefitActivityRewardCsReq>(() => new TakeBenefitActivityRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FHFMNOGAMHAFieldNumber = 1;

	private bool fHFMNOGAMHA_;

	public const int SwitchListFieldNumber = 3;

	private static readonly FieldCodec<IIJKILFJENL> _repeated_switchList_codec = FieldCodec.ForMessage(26u, IIJKILFJENL.Parser);

	private readonly RepeatedField<IIJKILFJENL> switchList_ = new RepeatedField<IIJKILFJENL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeBenefitActivityRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeBenefitActivityRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FHFMNOGAMHA
	{
		get
		{
			return fHFMNOGAMHA_;
		}
		set
		{
			fHFMNOGAMHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IIJKILFJENL> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBenefitActivityRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBenefitActivityRewardCsReq(TakeBenefitActivityRewardCsReq other)
		: this()
	{
		fHFMNOGAMHA_ = other.fHFMNOGAMHA_;
		switchList_ = other.switchList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBenefitActivityRewardCsReq Clone()
	{
		return new TakeBenefitActivityRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeBenefitActivityRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeBenefitActivityRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FHFMNOGAMHA != other.FHFMNOGAMHA)
		{
			return false;
		}
		if (!switchList_.Equals(other.switchList_))
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
		if (FHFMNOGAMHA)
		{
			num ^= FHFMNOGAMHA.GetHashCode();
		}
		num ^= switchList_.GetHashCode();
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
		if (FHFMNOGAMHA)
		{
			output.WriteRawTag(8);
			output.WriteBool(FHFMNOGAMHA);
		}
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
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
		if (FHFMNOGAMHA)
		{
			num += 2;
		}
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeBenefitActivityRewardCsReq other)
	{
		if (other != null)
		{
			if (other.FHFMNOGAMHA)
			{
				FHFMNOGAMHA = other.FHFMNOGAMHA;
			}
			switchList_.Add(other.switchList_);
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
				FHFMNOGAMHA = input.ReadBool();
				break;
			case 26u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			}
		}
	}
}
