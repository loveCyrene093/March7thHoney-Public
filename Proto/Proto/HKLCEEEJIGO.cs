using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKLCEEEJIGO : IMessage<HKLCEEEJIGO>, IMessage, IEquatable<HKLCEEEJIGO>, IDeepCloneable<HKLCEEEJIGO>, IBufferMessage
{
	private static readonly MessageParser<HKLCEEEJIGO> _parser = new MessageParser<HKLCEEEJIGO>(() => new HKLCEEEJIGO());

	private UnknownFieldSet _unknownFields;

	public const int ICILBNDIDGPFieldNumber = 4;

	private bool iCILBNDIDGP_;

	public const int UniqueIdFieldNumber = 6;

	private int uniqueId_;

	public const int HDNGJKKLLPMFieldNumber = 7;

	private IGKKFPDHJLK hDNGJKKLLPM_;

	public const int PosFieldNumber = 8;

	private OMJLLILGAEP pos_;

	public const int JMIENBBMPAGFieldNumber = 14;

	private uint jMIENBBMPAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKLCEEEJIGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKLCEEEJIGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICILBNDIDGP
	{
		get
		{
			return iCILBNDIDGP_;
		}
		set
		{
			iCILBNDIDGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGKKFPDHJLK HDNGJKKLLPM
	{
		get
		{
			return hDNGJKKLLPM_;
		}
		set
		{
			hDNGJKKLLPM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJLLILGAEP Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMIENBBMPAG
	{
		get
		{
			return jMIENBBMPAG_;
		}
		set
		{
			jMIENBBMPAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLCEEEJIGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLCEEEJIGO(HKLCEEEJIGO other)
		: this()
	{
		iCILBNDIDGP_ = other.iCILBNDIDGP_;
		uniqueId_ = other.uniqueId_;
		hDNGJKKLLPM_ = ((other.hDNGJKKLLPM_ != null) ? other.hDNGJKKLLPM_.Clone() : null);
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		jMIENBBMPAG_ = other.jMIENBBMPAG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLCEEEJIGO Clone()
	{
		return new HKLCEEEJIGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKLCEEEJIGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKLCEEEJIGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ICILBNDIDGP != other.ICILBNDIDGP)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(HDNGJKKLLPM, other.HDNGJKKLLPM))
		{
			return false;
		}
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (JMIENBBMPAG != other.JMIENBBMPAG)
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
		if (ICILBNDIDGP)
		{
			num ^= ICILBNDIDGP.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (hDNGJKKLLPM_ != null)
		{
			num ^= HDNGJKKLLPM.GetHashCode();
		}
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (JMIENBBMPAG != 0)
		{
			num ^= JMIENBBMPAG.GetHashCode();
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
		if (ICILBNDIDGP)
		{
			output.WriteRawTag(32);
			output.WriteBool(ICILBNDIDGP);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(UniqueId);
		}
		if (hDNGJKKLLPM_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HDNGJKKLLPM);
		}
		if (pos_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Pos);
		}
		if (JMIENBBMPAG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JMIENBBMPAG);
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
		if (ICILBNDIDGP)
		{
			num += 2;
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueId);
		}
		if (hDNGJKKLLPM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HDNGJKKLLPM);
		}
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (JMIENBBMPAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMIENBBMPAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKLCEEEJIGO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ICILBNDIDGP)
		{
			ICILBNDIDGP = other.ICILBNDIDGP;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.hDNGJKKLLPM_ != null)
		{
			if (hDNGJKKLLPM_ == null)
			{
				HDNGJKKLLPM = new IGKKFPDHJLK();
			}
			HDNGJKKLLPM.MergeFrom(other.HDNGJKKLLPM);
		}
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new OMJLLILGAEP();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.JMIENBBMPAG != 0)
		{
			JMIENBBMPAG = other.JMIENBBMPAG;
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
			case 32u:
				ICILBNDIDGP = input.ReadBool();
				break;
			case 48u:
				UniqueId = input.ReadInt32();
				break;
			case 58u:
				if (hDNGJKKLLPM_ == null)
				{
					HDNGJKKLLPM = new IGKKFPDHJLK();
				}
				input.ReadMessage(HDNGJKKLLPM);
				break;
			case 66u:
				if (pos_ == null)
				{
					Pos = new OMJLLILGAEP();
				}
				input.ReadMessage(Pos);
				break;
			case 112u:
				JMIENBBMPAG = input.ReadUInt32();
				break;
			}
		}
	}
}
