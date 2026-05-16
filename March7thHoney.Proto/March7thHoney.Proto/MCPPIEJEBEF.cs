using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCPPIEJEBEF : IMessage<MCPPIEJEBEF>, IMessage, IEquatable<MCPPIEJEBEF>, IDeepCloneable<MCPPIEJEBEF>, IBufferMessage
{
	private static readonly MessageParser<MCPPIEJEBEF> _parser = new MessageParser<MCPPIEJEBEF>(() => new MCPPIEJEBEF());

	private UnknownFieldSet _unknownFields;

	public const int LEKGBMCOJDBFieldNumber = 1;

	private NKLAFFLJCHG lEKGBMCOJDB_;

	public const int KBHPIPFKPACFieldNumber = 2;

	private static readonly FieldCodec<BHFONEFGGAG> _repeated_kBHPIPFKPAC_codec = FieldCodec.ForMessage(18u, BHFONEFGGAG.Parser);

	private readonly RepeatedField<BHFONEFGGAG> kBHPIPFKPAC_ = new RepeatedField<BHFONEFGGAG>();

	public const int HAJPKJOCBCLFieldNumber = 3;

	private bool hAJPKJOCBCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCPPIEJEBEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCPPIEJEBEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKLAFFLJCHG LEKGBMCOJDB
	{
		get
		{
			return lEKGBMCOJDB_;
		}
		set
		{
			lEKGBMCOJDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BHFONEFGGAG> KBHPIPFKPAC => kBHPIPFKPAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HAJPKJOCBCL
	{
		get
		{
			return hAJPKJOCBCL_;
		}
		set
		{
			hAJPKJOCBCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPPIEJEBEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPPIEJEBEF(MCPPIEJEBEF other)
		: this()
	{
		lEKGBMCOJDB_ = ((other.lEKGBMCOJDB_ != null) ? other.lEKGBMCOJDB_.Clone() : null);
		kBHPIPFKPAC_ = other.kBHPIPFKPAC_.Clone();
		hAJPKJOCBCL_ = other.hAJPKJOCBCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPPIEJEBEF Clone()
	{
		return new MCPPIEJEBEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCPPIEJEBEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCPPIEJEBEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LEKGBMCOJDB, other.LEKGBMCOJDB))
		{
			return false;
		}
		if (!kBHPIPFKPAC_.Equals(other.kBHPIPFKPAC_))
		{
			return false;
		}
		if (HAJPKJOCBCL != other.HAJPKJOCBCL)
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
		if (lEKGBMCOJDB_ != null)
		{
			num ^= LEKGBMCOJDB.GetHashCode();
		}
		num ^= kBHPIPFKPAC_.GetHashCode();
		if (HAJPKJOCBCL)
		{
			num ^= HAJPKJOCBCL.GetHashCode();
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
		if (lEKGBMCOJDB_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(LEKGBMCOJDB);
		}
		kBHPIPFKPAC_.WriteTo(ref output, _repeated_kBHPIPFKPAC_codec);
		if (HAJPKJOCBCL)
		{
			output.WriteRawTag(24);
			output.WriteBool(HAJPKJOCBCL);
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
		if (lEKGBMCOJDB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LEKGBMCOJDB);
		}
		num += kBHPIPFKPAC_.CalculateSize(_repeated_kBHPIPFKPAC_codec);
		if (HAJPKJOCBCL)
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
	public void MergeFrom(MCPPIEJEBEF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lEKGBMCOJDB_ != null)
		{
			if (lEKGBMCOJDB_ == null)
			{
				LEKGBMCOJDB = new NKLAFFLJCHG();
			}
			LEKGBMCOJDB.MergeFrom(other.LEKGBMCOJDB);
		}
		kBHPIPFKPAC_.Add(other.kBHPIPFKPAC_);
		if (other.HAJPKJOCBCL)
		{
			HAJPKJOCBCL = other.HAJPKJOCBCL;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (lEKGBMCOJDB_ == null)
				{
					LEKGBMCOJDB = new NKLAFFLJCHG();
				}
				input.ReadMessage(LEKGBMCOJDB);
				break;
			case 18u:
				kBHPIPFKPAC_.AddEntriesFrom(ref input, _repeated_kBHPIPFKPAC_codec);
				break;
			case 24u:
				HAJPKJOCBCL = input.ReadBool();
				break;
			}
		}
	}
}
