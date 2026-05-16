using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CALIIIHMJAC : IMessage<CALIIIHMJAC>, IMessage, IEquatable<CALIIIHMJAC>, IDeepCloneable<CALIIIHMJAC>, IBufferMessage
{
	private static readonly MessageParser<CALIIIHMJAC> _parser = new MessageParser<CALIIIHMJAC>(() => new CALIIIHMJAC());

	private UnknownFieldSet _unknownFields;

	public const int PPIPFOPHNHMFieldNumber = 6;

	private MNCOPDNELMC pPIPFOPHNHM_;

	public const int EAADBOCJNAEFieldNumber = 8;

	private uint eAADBOCJNAE_;

	public const int CGNOKHABCPPFieldNumber = 10;

	private int cGNOKHABCPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CALIIIHMJAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CALIIIHMJACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNCOPDNELMC PPIPFOPHNHM
	{
		get
		{
			return pPIPFOPHNHM_;
		}
		set
		{
			pPIPFOPHNHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EAADBOCJNAE
	{
		get
		{
			return eAADBOCJNAE_;
		}
		set
		{
			eAADBOCJNAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CGNOKHABCPP
	{
		get
		{
			return cGNOKHABCPP_;
		}
		set
		{
			cGNOKHABCPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIIIHMJAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIIIHMJAC(CALIIIHMJAC other)
		: this()
	{
		pPIPFOPHNHM_ = ((other.pPIPFOPHNHM_ != null) ? other.pPIPFOPHNHM_.Clone() : null);
		eAADBOCJNAE_ = other.eAADBOCJNAE_;
		cGNOKHABCPP_ = other.cGNOKHABCPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIIIHMJAC Clone()
	{
		return new CALIIIHMJAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CALIIIHMJAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CALIIIHMJAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PPIPFOPHNHM, other.PPIPFOPHNHM))
		{
			return false;
		}
		if (EAADBOCJNAE != other.EAADBOCJNAE)
		{
			return false;
		}
		if (CGNOKHABCPP != other.CGNOKHABCPP)
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
		if (pPIPFOPHNHM_ != null)
		{
			num ^= PPIPFOPHNHM.GetHashCode();
		}
		if (EAADBOCJNAE != 0)
		{
			num ^= EAADBOCJNAE.GetHashCode();
		}
		if (CGNOKHABCPP != 0)
		{
			num ^= CGNOKHABCPP.GetHashCode();
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
		if (pPIPFOPHNHM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PPIPFOPHNHM);
		}
		if (EAADBOCJNAE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EAADBOCJNAE);
		}
		if (CGNOKHABCPP != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CGNOKHABCPP);
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
		if (pPIPFOPHNHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPIPFOPHNHM);
		}
		if (EAADBOCJNAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EAADBOCJNAE);
		}
		if (CGNOKHABCPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CGNOKHABCPP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CALIIIHMJAC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pPIPFOPHNHM_ != null)
		{
			if (pPIPFOPHNHM_ == null)
			{
				PPIPFOPHNHM = new MNCOPDNELMC();
			}
			PPIPFOPHNHM.MergeFrom(other.PPIPFOPHNHM);
		}
		if (other.EAADBOCJNAE != 0)
		{
			EAADBOCJNAE = other.EAADBOCJNAE;
		}
		if (other.CGNOKHABCPP != 0)
		{
			CGNOKHABCPP = other.CGNOKHABCPP;
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
			case 50u:
				if (pPIPFOPHNHM_ == null)
				{
					PPIPFOPHNHM = new MNCOPDNELMC();
				}
				input.ReadMessage(PPIPFOPHNHM);
				break;
			case 64u:
				EAADBOCJNAE = input.ReadUInt32();
				break;
			case 80u:
				CGNOKHABCPP = input.ReadInt32();
				break;
			}
		}
	}
}
