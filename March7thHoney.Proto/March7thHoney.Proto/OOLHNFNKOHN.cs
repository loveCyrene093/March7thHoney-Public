using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOLHNFNKOHN : IMessage<OOLHNFNKOHN>, IMessage, IEquatable<OOLHNFNKOHN>, IDeepCloneable<OOLHNFNKOHN>, IBufferMessage
{
	private static readonly MessageParser<OOLHNFNKOHN> _parser = new MessageParser<OOLHNFNKOHN>(() => new OOLHNFNKOHN());

	private UnknownFieldSet _unknownFields;

	public const int JNHABODMEKPFieldNumber = 3;

	private uint jNHABODMEKP_;

	public const int LDGFEIPOFIBFieldNumber = 9;

	private uint lDGFEIPOFIB_;

	public const int HFEBCKJHJOAFieldNumber = 10;

	private ECELDDGKCAK hFEBCKJHJOA_;

	public const int PDOBPEBHKPDFieldNumber = 11;

	private FNABDKEBCOC pDOBPEBHKPD_;

	public const int LJJAJGFIGNMFieldNumber = 13;

	private DGKNDMAHMAP lJJAJGFIGNM_;

	public const int DMPGNLIBNDEFieldNumber = 14;

	private uint dMPGNLIBNDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOLHNFNKOHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOLHNFNKOHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNHABODMEKP
	{
		get
		{
			return jNHABODMEKP_;
		}
		set
		{
			jNHABODMEKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDGFEIPOFIB
	{
		get
		{
			return lDGFEIPOFIB_;
		}
		set
		{
			lDGFEIPOFIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ECELDDGKCAK HFEBCKJHJOA
	{
		get
		{
			return hFEBCKJHJOA_;
		}
		set
		{
			hFEBCKJHJOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNABDKEBCOC PDOBPEBHKPD
	{
		get
		{
			return pDOBPEBHKPD_;
		}
		set
		{
			pDOBPEBHKPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP LJJAJGFIGNM
	{
		get
		{
			return lJJAJGFIGNM_;
		}
		set
		{
			lJJAJGFIGNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMPGNLIBNDE
	{
		get
		{
			return dMPGNLIBNDE_;
		}
		set
		{
			dMPGNLIBNDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOLHNFNKOHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOLHNFNKOHN(OOLHNFNKOHN other)
		: this()
	{
		jNHABODMEKP_ = other.jNHABODMEKP_;
		lDGFEIPOFIB_ = other.lDGFEIPOFIB_;
		hFEBCKJHJOA_ = ((other.hFEBCKJHJOA_ != null) ? other.hFEBCKJHJOA_.Clone() : null);
		pDOBPEBHKPD_ = ((other.pDOBPEBHKPD_ != null) ? other.pDOBPEBHKPD_.Clone() : null);
		lJJAJGFIGNM_ = ((other.lJJAJGFIGNM_ != null) ? other.lJJAJGFIGNM_.Clone() : null);
		dMPGNLIBNDE_ = other.dMPGNLIBNDE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOLHNFNKOHN Clone()
	{
		return new OOLHNFNKOHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOLHNFNKOHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOLHNFNKOHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JNHABODMEKP != other.JNHABODMEKP)
		{
			return false;
		}
		if (LDGFEIPOFIB != other.LDGFEIPOFIB)
		{
			return false;
		}
		if (!object.Equals(HFEBCKJHJOA, other.HFEBCKJHJOA))
		{
			return false;
		}
		if (!object.Equals(PDOBPEBHKPD, other.PDOBPEBHKPD))
		{
			return false;
		}
		if (!object.Equals(LJJAJGFIGNM, other.LJJAJGFIGNM))
		{
			return false;
		}
		if (DMPGNLIBNDE != other.DMPGNLIBNDE)
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
		if (JNHABODMEKP != 0)
		{
			num ^= JNHABODMEKP.GetHashCode();
		}
		if (LDGFEIPOFIB != 0)
		{
			num ^= LDGFEIPOFIB.GetHashCode();
		}
		if (hFEBCKJHJOA_ != null)
		{
			num ^= HFEBCKJHJOA.GetHashCode();
		}
		if (pDOBPEBHKPD_ != null)
		{
			num ^= PDOBPEBHKPD.GetHashCode();
		}
		if (lJJAJGFIGNM_ != null)
		{
			num ^= LJJAJGFIGNM.GetHashCode();
		}
		if (DMPGNLIBNDE != 0)
		{
			num ^= DMPGNLIBNDE.GetHashCode();
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
		if (JNHABODMEKP != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JNHABODMEKP);
		}
		if (LDGFEIPOFIB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LDGFEIPOFIB);
		}
		if (hFEBCKJHJOA_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(HFEBCKJHJOA);
		}
		if (pDOBPEBHKPD_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PDOBPEBHKPD);
		}
		if (lJJAJGFIGNM_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(LJJAJGFIGNM);
		}
		if (DMPGNLIBNDE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DMPGNLIBNDE);
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
		if (JNHABODMEKP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNHABODMEKP);
		}
		if (LDGFEIPOFIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDGFEIPOFIB);
		}
		if (hFEBCKJHJOA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HFEBCKJHJOA);
		}
		if (pDOBPEBHKPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PDOBPEBHKPD);
		}
		if (lJJAJGFIGNM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJJAJGFIGNM);
		}
		if (DMPGNLIBNDE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMPGNLIBNDE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOLHNFNKOHN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JNHABODMEKP != 0)
		{
			JNHABODMEKP = other.JNHABODMEKP;
		}
		if (other.LDGFEIPOFIB != 0)
		{
			LDGFEIPOFIB = other.LDGFEIPOFIB;
		}
		if (other.hFEBCKJHJOA_ != null)
		{
			if (hFEBCKJHJOA_ == null)
			{
				HFEBCKJHJOA = new ECELDDGKCAK();
			}
			HFEBCKJHJOA.MergeFrom(other.HFEBCKJHJOA);
		}
		if (other.pDOBPEBHKPD_ != null)
		{
			if (pDOBPEBHKPD_ == null)
			{
				PDOBPEBHKPD = new FNABDKEBCOC();
			}
			PDOBPEBHKPD.MergeFrom(other.PDOBPEBHKPD);
		}
		if (other.lJJAJGFIGNM_ != null)
		{
			if (lJJAJGFIGNM_ == null)
			{
				LJJAJGFIGNM = new DGKNDMAHMAP();
			}
			LJJAJGFIGNM.MergeFrom(other.LJJAJGFIGNM);
		}
		if (other.DMPGNLIBNDE != 0)
		{
			DMPGNLIBNDE = other.DMPGNLIBNDE;
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
			case 24u:
				JNHABODMEKP = input.ReadUInt32();
				break;
			case 72u:
				LDGFEIPOFIB = input.ReadUInt32();
				break;
			case 82u:
				if (hFEBCKJHJOA_ == null)
				{
					HFEBCKJHJOA = new ECELDDGKCAK();
				}
				input.ReadMessage(HFEBCKJHJOA);
				break;
			case 90u:
				if (pDOBPEBHKPD_ == null)
				{
					PDOBPEBHKPD = new FNABDKEBCOC();
				}
				input.ReadMessage(PDOBPEBHKPD);
				break;
			case 106u:
				if (lJJAJGFIGNM_ == null)
				{
					LJJAJGFIGNM = new DGKNDMAHMAP();
				}
				input.ReadMessage(LJJAJGFIGNM);
				break;
			case 112u:
				DMPGNLIBNDE = input.ReadUInt32();
				break;
			}
		}
	}
}
