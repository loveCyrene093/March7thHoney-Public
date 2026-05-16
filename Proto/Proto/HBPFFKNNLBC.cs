using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBPFFKNNLBC : IMessage<HBPFFKNNLBC>, IMessage, IEquatable<HBPFFKNNLBC>, IDeepCloneable<HBPFFKNNLBC>, IBufferMessage
{
	private static readonly MessageParser<HBPFFKNNLBC> _parser = new MessageParser<HBPFFKNNLBC>(() => new HBPFFKNNLBC());

	private UnknownFieldSet _unknownFields;

	public const int PanelIdFieldNumber = 3;

	private uint panelId_;

	public const int KAPGHPNEOEKFieldNumber = 6;

	private uint kAPGHPNEOEK_;

	public const int CNJEEKKMLJKFieldNumber = 7;

	private bool cNJEEKKMLJK_;

	public const int IsTakenRewardFieldNumber = 11;

	private bool isTakenReward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBPFFKNNLBC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBPFFKNNLBCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KAPGHPNEOEK
	{
		get
		{
			return kAPGHPNEOEK_;
		}
		set
		{
			kAPGHPNEOEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CNJEEKKMLJK
	{
		get
		{
			return cNJEEKKMLJK_;
		}
		set
		{
			cNJEEKKMLJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBPFFKNNLBC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBPFFKNNLBC(HBPFFKNNLBC other)
		: this()
	{
		panelId_ = other.panelId_;
		kAPGHPNEOEK_ = other.kAPGHPNEOEK_;
		cNJEEKKMLJK_ = other.cNJEEKKMLJK_;
		isTakenReward_ = other.isTakenReward_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBPFFKNNLBC Clone()
	{
		return new HBPFFKNNLBC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBPFFKNNLBC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBPFFKNNLBC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (KAPGHPNEOEK != other.KAPGHPNEOEK)
		{
			return false;
		}
		if (CNJEEKKMLJK != other.CNJEEKKMLJK)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
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
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (KAPGHPNEOEK != 0)
		{
			num ^= KAPGHPNEOEK.GetHashCode();
		}
		if (CNJEEKKMLJK)
		{
			num ^= CNJEEKKMLJK.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
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
		if (PanelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PanelId);
		}
		if (KAPGHPNEOEK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KAPGHPNEOEK);
		}
		if (CNJEEKKMLJK)
		{
			output.WriteRawTag(56);
			output.WriteBool(CNJEEKKMLJK);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsTakenReward);
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
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (KAPGHPNEOEK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KAPGHPNEOEK);
		}
		if (CNJEEKKMLJK)
		{
			num += 2;
		}
		if (IsTakenReward)
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
	public void MergeFrom(HBPFFKNNLBC other)
	{
		if (other != null)
		{
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.KAPGHPNEOEK != 0)
			{
				KAPGHPNEOEK = other.KAPGHPNEOEK;
			}
			if (other.CNJEEKKMLJK)
			{
				CNJEEKKMLJK = other.CNJEEKKMLJK;
			}
			if (other.IsTakenReward)
			{
				IsTakenReward = other.IsTakenReward;
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
			case 24u:
				PanelId = input.ReadUInt32();
				break;
			case 48u:
				KAPGHPNEOEK = input.ReadUInt32();
				break;
			case 56u:
				CNJEEKKMLJK = input.ReadBool();
				break;
			case 88u:
				IsTakenReward = input.ReadBool();
				break;
			}
		}
	}
}
