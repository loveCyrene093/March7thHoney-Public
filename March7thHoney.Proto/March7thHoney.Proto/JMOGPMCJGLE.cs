using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JMOGPMCJGLE : IMessage<JMOGPMCJGLE>, IMessage, IEquatable<JMOGPMCJGLE>, IDeepCloneable<JMOGPMCJGLE>, IBufferMessage
{
	private static readonly MessageParser<JMOGPMCJGLE> _parser = new MessageParser<JMOGPMCJGLE>(() => new JMOGPMCJGLE());

	private UnknownFieldSet _unknownFields;

	public const int EAADBOCJNAEFieldNumber = 4;

	private uint eAADBOCJNAE_;

	public const int CGNOKHABCPPFieldNumber = 7;

	private int cGNOKHABCPP_;

	public const int PPIPFOPHNHMFieldNumber = 8;

	private MNCOPDNELMC pPIPFOPHNHM_;

	public const int EPKENDEAJPBFieldNumber = 9;

	private ICHBGLCHLDP ePKENDEAJPB_;

	public const int KJDGGNNFGGPFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_kJDGGNNFGGP_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> kJDGGNNFGGP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JMOGPMCJGLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JMOGPMCJGLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public ICHBGLCHLDP EPKENDEAJPB
	{
		get
		{
			return ePKENDEAJPB_;
		}
		set
		{
			ePKENDEAJPB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KJDGGNNFGGP => kJDGGNNFGGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMOGPMCJGLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMOGPMCJGLE(JMOGPMCJGLE other)
		: this()
	{
		eAADBOCJNAE_ = other.eAADBOCJNAE_;
		cGNOKHABCPP_ = other.cGNOKHABCPP_;
		pPIPFOPHNHM_ = ((other.pPIPFOPHNHM_ != null) ? other.pPIPFOPHNHM_.Clone() : null);
		ePKENDEAJPB_ = ((other.ePKENDEAJPB_ != null) ? other.ePKENDEAJPB_.Clone() : null);
		kJDGGNNFGGP_ = other.kJDGGNNFGGP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMOGPMCJGLE Clone()
	{
		return new JMOGPMCJGLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JMOGPMCJGLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JMOGPMCJGLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EAADBOCJNAE != other.EAADBOCJNAE)
		{
			return false;
		}
		if (CGNOKHABCPP != other.CGNOKHABCPP)
		{
			return false;
		}
		if (!object.Equals(PPIPFOPHNHM, other.PPIPFOPHNHM))
		{
			return false;
		}
		if (!object.Equals(EPKENDEAJPB, other.EPKENDEAJPB))
		{
			return false;
		}
		if (!kJDGGNNFGGP_.Equals(other.kJDGGNNFGGP_))
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
		if (EAADBOCJNAE != 0)
		{
			num ^= EAADBOCJNAE.GetHashCode();
		}
		if (CGNOKHABCPP != 0)
		{
			num ^= CGNOKHABCPP.GetHashCode();
		}
		if (pPIPFOPHNHM_ != null)
		{
			num ^= PPIPFOPHNHM.GetHashCode();
		}
		if (ePKENDEAJPB_ != null)
		{
			num ^= EPKENDEAJPB.GetHashCode();
		}
		num ^= kJDGGNNFGGP_.GetHashCode();
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
		if (EAADBOCJNAE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EAADBOCJNAE);
		}
		if (CGNOKHABCPP != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CGNOKHABCPP);
		}
		if (pPIPFOPHNHM_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PPIPFOPHNHM);
		}
		if (ePKENDEAJPB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EPKENDEAJPB);
		}
		kJDGGNNFGGP_.WriteTo(ref output, _repeated_kJDGGNNFGGP_codec);
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
		if (EAADBOCJNAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EAADBOCJNAE);
		}
		if (CGNOKHABCPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CGNOKHABCPP);
		}
		if (pPIPFOPHNHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PPIPFOPHNHM);
		}
		if (ePKENDEAJPB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EPKENDEAJPB);
		}
		num += kJDGGNNFGGP_.CalculateSize(_repeated_kJDGGNNFGGP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JMOGPMCJGLE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EAADBOCJNAE != 0)
		{
			EAADBOCJNAE = other.EAADBOCJNAE;
		}
		if (other.CGNOKHABCPP != 0)
		{
			CGNOKHABCPP = other.CGNOKHABCPP;
		}
		if (other.pPIPFOPHNHM_ != null)
		{
			if (pPIPFOPHNHM_ == null)
			{
				PPIPFOPHNHM = new MNCOPDNELMC();
			}
			PPIPFOPHNHM.MergeFrom(other.PPIPFOPHNHM);
		}
		if (other.ePKENDEAJPB_ != null)
		{
			if (ePKENDEAJPB_ == null)
			{
				EPKENDEAJPB = new ICHBGLCHLDP();
			}
			EPKENDEAJPB.MergeFrom(other.EPKENDEAJPB);
		}
		kJDGGNNFGGP_.Add(other.kJDGGNNFGGP_);
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
			case 32u:
				EAADBOCJNAE = input.ReadUInt32();
				break;
			case 56u:
				CGNOKHABCPP = input.ReadInt32();
				break;
			case 66u:
				if (pPIPFOPHNHM_ == null)
				{
					PPIPFOPHNHM = new MNCOPDNELMC();
				}
				input.ReadMessage(PPIPFOPHNHM);
				break;
			case 74u:
				if (ePKENDEAJPB_ == null)
				{
					EPKENDEAJPB = new ICHBGLCHLDP();
				}
				input.ReadMessage(EPKENDEAJPB);
				break;
			case 112u:
			case 114u:
				kJDGGNNFGGP_.AddEntriesFrom(ref input, _repeated_kJDGGNNFGGP_codec);
				break;
			}
		}
	}
}
