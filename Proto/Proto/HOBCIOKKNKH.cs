using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HOBCIOKKNKH : IMessage<HOBCIOKKNKH>, IMessage, IEquatable<HOBCIOKKNKH>, IDeepCloneable<HOBCIOKKNKH>, IBufferMessage
{
	private static readonly MessageParser<HOBCIOKKNKH> _parser = new MessageParser<HOBCIOKKNKH>(() => new HOBCIOKKNKH());

	private UnknownFieldSet _unknownFields;

	public const int MAPDNLBHHCDFieldNumber = 4;

	private uint mAPDNLBHHCD_;

	public const int OIAPHBBDPHLFieldNumber = 6;

	private DDJOEIBOELH oIAPHBBDPHL_;

	public const int GEPGGGDKBNKFieldNumber = 9;

	private ChimeraDuelPlayerRankData gEPGGGDKBNK_;

	public const int GILDMPKFGGCFieldNumber = 15;

	private bool gILDMPKFGGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HOBCIOKKNKH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HOBCIOKKNKHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAPDNLBHHCD
	{
		get
		{
			return mAPDNLBHHCD_;
		}
		set
		{
			mAPDNLBHHCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH OIAPHBBDPHL
	{
		get
		{
			return oIAPHBBDPHL_;
		}
		set
		{
			oIAPHBBDPHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelPlayerRankData GEPGGGDKBNK
	{
		get
		{
			return gEPGGGDKBNK_;
		}
		set
		{
			gEPGGGDKBNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GILDMPKFGGC
	{
		get
		{
			return gILDMPKFGGC_;
		}
		set
		{
			gILDMPKFGGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBCIOKKNKH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBCIOKKNKH(HOBCIOKKNKH other)
		: this()
	{
		mAPDNLBHHCD_ = other.mAPDNLBHHCD_;
		oIAPHBBDPHL_ = ((other.oIAPHBBDPHL_ != null) ? other.oIAPHBBDPHL_.Clone() : null);
		gEPGGGDKBNK_ = ((other.gEPGGGDKBNK_ != null) ? other.gEPGGGDKBNK_.Clone() : null);
		gILDMPKFGGC_ = other.gILDMPKFGGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBCIOKKNKH Clone()
	{
		return new HOBCIOKKNKH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HOBCIOKKNKH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HOBCIOKKNKH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MAPDNLBHHCD != other.MAPDNLBHHCD)
		{
			return false;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
		{
			return false;
		}
		if (!object.Equals(GEPGGGDKBNK, other.GEPGGGDKBNK))
		{
			return false;
		}
		if (GILDMPKFGGC != other.GILDMPKFGGC)
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
		if (MAPDNLBHHCD != 0)
		{
			num ^= MAPDNLBHHCD.GetHashCode();
		}
		if (oIAPHBBDPHL_ != null)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
		}
		if (gEPGGGDKBNK_ != null)
		{
			num ^= GEPGGGDKBNK.GetHashCode();
		}
		if (GILDMPKFGGC)
		{
			num ^= GILDMPKFGGC.GetHashCode();
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
		if (MAPDNLBHHCD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MAPDNLBHHCD);
		}
		if (oIAPHBBDPHL_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (gEPGGGDKBNK_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GEPGGGDKBNK);
		}
		if (GILDMPKFGGC)
		{
			output.WriteRawTag(120);
			output.WriteBool(GILDMPKFGGC);
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
		if (MAPDNLBHHCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAPDNLBHHCD);
		}
		if (oIAPHBBDPHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
		}
		if (gEPGGGDKBNK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GEPGGGDKBNK);
		}
		if (GILDMPKFGGC)
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
	public void MergeFrom(HOBCIOKKNKH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MAPDNLBHHCD != 0)
		{
			MAPDNLBHHCD = other.MAPDNLBHHCD;
		}
		if (other.oIAPHBBDPHL_ != null)
		{
			if (oIAPHBBDPHL_ == null)
			{
				OIAPHBBDPHL = new DDJOEIBOELH();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
		}
		if (other.gEPGGGDKBNK_ != null)
		{
			if (gEPGGGDKBNK_ == null)
			{
				GEPGGGDKBNK = new ChimeraDuelPlayerRankData();
			}
			GEPGGGDKBNK.MergeFrom(other.GEPGGGDKBNK);
		}
		if (other.GILDMPKFGGC)
		{
			GILDMPKFGGC = other.GILDMPKFGGC;
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
				MAPDNLBHHCD = input.ReadUInt32();
				break;
			case 50u:
				if (oIAPHBBDPHL_ == null)
				{
					OIAPHBBDPHL = new DDJOEIBOELH();
				}
				input.ReadMessage(OIAPHBBDPHL);
				break;
			case 74u:
				if (gEPGGGDKBNK_ == null)
				{
					GEPGGGDKBNK = new ChimeraDuelPlayerRankData();
				}
				input.ReadMessage(GEPGGGDKBNK);
				break;
			case 120u:
				GILDMPKFGGC = input.ReadBool();
				break;
			}
		}
	}
}
