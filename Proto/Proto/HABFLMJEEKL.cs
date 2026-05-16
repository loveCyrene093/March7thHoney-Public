using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HABFLMJEEKL : IMessage<HABFLMJEEKL>, IMessage, IEquatable<HABFLMJEEKL>, IDeepCloneable<HABFLMJEEKL>, IBufferMessage
{
	private static readonly MessageParser<HABFLMJEEKL> _parser = new MessageParser<HABFLMJEEKL>(() => new HABFLMJEEKL());

	private UnknownFieldSet _unknownFields;

	public const int JGBEBENBLADFieldNumber = 1;

	private static readonly FieldCodec<BNDOCFACDLL> _repeated_jGBEBENBLAD_codec = FieldCodec.ForMessage(10u, BNDOCFACDLL.Parser);

	private readonly RepeatedField<BNDOCFACDLL> jGBEBENBLAD_ = new RepeatedField<BNDOCFACDLL>();

	public const int DCLAKCFJCPJFieldNumber = 2;

	private static readonly FieldCodec<BPDFEOGCAIJ> _repeated_dCLAKCFJCPJ_codec = FieldCodec.ForMessage(18u, BPDFEOGCAIJ.Parser);

	private readonly RepeatedField<BPDFEOGCAIJ> dCLAKCFJCPJ_ = new RepeatedField<BPDFEOGCAIJ>();

	public const int EHJBMNMOFLFFieldNumber = 3;

	private uint eHJBMNMOFLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HABFLMJEEKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HABFLMJEEKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BNDOCFACDLL> JGBEBENBLAD => jGBEBENBLAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BPDFEOGCAIJ> DCLAKCFJCPJ => dCLAKCFJCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHJBMNMOFLF
	{
		get
		{
			return eHJBMNMOFLF_;
		}
		set
		{
			eHJBMNMOFLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABFLMJEEKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABFLMJEEKL(HABFLMJEEKL other)
		: this()
	{
		jGBEBENBLAD_ = other.jGBEBENBLAD_.Clone();
		dCLAKCFJCPJ_ = other.dCLAKCFJCPJ_.Clone();
		eHJBMNMOFLF_ = other.eHJBMNMOFLF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HABFLMJEEKL Clone()
	{
		return new HABFLMJEEKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HABFLMJEEKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HABFLMJEEKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jGBEBENBLAD_.Equals(other.jGBEBENBLAD_))
		{
			return false;
		}
		if (!dCLAKCFJCPJ_.Equals(other.dCLAKCFJCPJ_))
		{
			return false;
		}
		if (EHJBMNMOFLF != other.EHJBMNMOFLF)
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
		num ^= jGBEBENBLAD_.GetHashCode();
		num ^= dCLAKCFJCPJ_.GetHashCode();
		if (EHJBMNMOFLF != 0)
		{
			num ^= EHJBMNMOFLF.GetHashCode();
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
		jGBEBENBLAD_.WriteTo(ref output, _repeated_jGBEBENBLAD_codec);
		dCLAKCFJCPJ_.WriteTo(ref output, _repeated_dCLAKCFJCPJ_codec);
		if (EHJBMNMOFLF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EHJBMNMOFLF);
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
		num += jGBEBENBLAD_.CalculateSize(_repeated_jGBEBENBLAD_codec);
		num += dCLAKCFJCPJ_.CalculateSize(_repeated_dCLAKCFJCPJ_codec);
		if (EHJBMNMOFLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHJBMNMOFLF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HABFLMJEEKL other)
	{
		if (other != null)
		{
			jGBEBENBLAD_.Add(other.jGBEBENBLAD_);
			dCLAKCFJCPJ_.Add(other.dCLAKCFJCPJ_);
			if (other.EHJBMNMOFLF != 0)
			{
				EHJBMNMOFLF = other.EHJBMNMOFLF;
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
				jGBEBENBLAD_.AddEntriesFrom(ref input, _repeated_jGBEBENBLAD_codec);
				break;
			case 18u:
				dCLAKCFJCPJ_.AddEntriesFrom(ref input, _repeated_dCLAKCFJCPJ_codec);
				break;
			case 24u:
				EHJBMNMOFLF = input.ReadUInt32();
				break;
			}
		}
	}
}
