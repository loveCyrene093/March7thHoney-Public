using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueAdventureRoomGameplayWolfGunTarget : IMessage<RogueAdventureRoomGameplayWolfGunTarget>, IMessage, IEquatable<RogueAdventureRoomGameplayWolfGunTarget>, IDeepCloneable<RogueAdventureRoomGameplayWolfGunTarget>, IBufferMessage
{
	public enum TargetImplOneofCase
	{
		None = 0,
		TargetNone = 1,
		TargetRuanmei = 7,
		TargetCoin = 12,
		TargetMiracle = 15
	}

	private static readonly MessageParser<RogueAdventureRoomGameplayWolfGunTarget> _parser = new MessageParser<RogueAdventureRoomGameplayWolfGunTarget>(() => new RogueAdventureRoomGameplayWolfGunTarget());

	private UnknownFieldSet _unknownFields;

	public const int TargetNoneFieldNumber = 1;

	public const int TargetRuanmeiFieldNumber = 7;

	public const int TargetCoinFieldNumber = 12;

	public const int TargetMiracleFieldNumber = 15;

	private object targetImpl_;

	private TargetImplOneofCase targetImplCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueAdventureRoomGameplayWolfGunTarget> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueAdventureRoomGameplayWolfGunTargetReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIDALMMDIEF TargetNone
	{
		get
		{
			if (targetImplCase_ != TargetImplOneofCase.TargetNone)
			{
				return null;
			}
			return (KIDALMMDIEF)targetImpl_;
		}
		set
		{
			targetImpl_ = value;
			targetImplCase_ = ((value != null) ? TargetImplOneofCase.TargetNone : TargetImplOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHEOKGAKGMA TargetRuanmei
	{
		get
		{
			if (targetImplCase_ != TargetImplOneofCase.TargetRuanmei)
			{
				return null;
			}
			return (BHEOKGAKGMA)targetImpl_;
		}
		set
		{
			targetImpl_ = value;
			targetImplCase_ = ((value != null) ? TargetImplOneofCase.TargetRuanmei : TargetImplOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDHOKGLFPKF TargetCoin
	{
		get
		{
			if (targetImplCase_ != TargetImplOneofCase.TargetCoin)
			{
				return null;
			}
			return (LDHOKGLFPKF)targetImpl_;
		}
		set
		{
			targetImpl_ = value;
			targetImplCase_ = ((value != null) ? TargetImplOneofCase.TargetCoin : TargetImplOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHPMAPGKILE TargetMiracle
	{
		get
		{
			if (targetImplCase_ != TargetImplOneofCase.TargetMiracle)
			{
				return null;
			}
			return (MHPMAPGKILE)targetImpl_;
		}
		set
		{
			targetImpl_ = value;
			targetImplCase_ = ((value != null) ? TargetImplOneofCase.TargetMiracle : TargetImplOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TargetImplOneofCase TargetImplCase => targetImplCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueAdventureRoomGameplayWolfGunTarget()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueAdventureRoomGameplayWolfGunTarget(RogueAdventureRoomGameplayWolfGunTarget other)
		: this()
	{
		switch (other.TargetImplCase)
		{
		case TargetImplOneofCase.TargetNone:
			TargetNone = other.TargetNone.Clone();
			break;
		case TargetImplOneofCase.TargetRuanmei:
			TargetRuanmei = other.TargetRuanmei.Clone();
			break;
		case TargetImplOneofCase.TargetCoin:
			TargetCoin = other.TargetCoin.Clone();
			break;
		case TargetImplOneofCase.TargetMiracle:
			TargetMiracle = other.TargetMiracle.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueAdventureRoomGameplayWolfGunTarget Clone()
	{
		return new RogueAdventureRoomGameplayWolfGunTarget(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTargetImpl()
	{
		targetImplCase_ = TargetImplOneofCase.None;
		targetImpl_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueAdventureRoomGameplayWolfGunTarget);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueAdventureRoomGameplayWolfGunTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TargetNone, other.TargetNone))
		{
			return false;
		}
		if (!object.Equals(TargetRuanmei, other.TargetRuanmei))
		{
			return false;
		}
		if (!object.Equals(TargetCoin, other.TargetCoin))
		{
			return false;
		}
		if (!object.Equals(TargetMiracle, other.TargetMiracle))
		{
			return false;
		}
		if (TargetImplCase != other.TargetImplCase)
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
		if (targetImplCase_ == TargetImplOneofCase.TargetNone)
		{
			num ^= TargetNone.GetHashCode();
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetRuanmei)
		{
			num ^= TargetRuanmei.GetHashCode();
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetCoin)
		{
			num ^= TargetCoin.GetHashCode();
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetMiracle)
		{
			num ^= TargetMiracle.GetHashCode();
		}
		num ^= (int)targetImplCase_;
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
		if (targetImplCase_ == TargetImplOneofCase.TargetNone)
		{
			output.WriteRawTag(10);
			output.WriteMessage(TargetNone);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetRuanmei)
		{
			output.WriteRawTag(58);
			output.WriteMessage(TargetRuanmei);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetCoin)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TargetCoin);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetMiracle)
		{
			output.WriteRawTag(122);
			output.WriteMessage(TargetMiracle);
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
		if (targetImplCase_ == TargetImplOneofCase.TargetNone)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetNone);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetRuanmei)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetRuanmei);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetCoin)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetCoin);
		}
		if (targetImplCase_ == TargetImplOneofCase.TargetMiracle)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetMiracle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueAdventureRoomGameplayWolfGunTarget other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.TargetImplCase)
		{
		case TargetImplOneofCase.TargetNone:
			if (TargetNone == null)
			{
				TargetNone = new KIDALMMDIEF();
			}
			TargetNone.MergeFrom(other.TargetNone);
			break;
		case TargetImplOneofCase.TargetRuanmei:
			if (TargetRuanmei == null)
			{
				TargetRuanmei = new BHEOKGAKGMA();
			}
			TargetRuanmei.MergeFrom(other.TargetRuanmei);
			break;
		case TargetImplOneofCase.TargetCoin:
			if (TargetCoin == null)
			{
				TargetCoin = new LDHOKGLFPKF();
			}
			TargetCoin.MergeFrom(other.TargetCoin);
			break;
		case TargetImplOneofCase.TargetMiracle:
			if (TargetMiracle == null)
			{
				TargetMiracle = new MHPMAPGKILE();
			}
			TargetMiracle.MergeFrom(other.TargetMiracle);
			break;
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
			{
				KIDALMMDIEF kIDALMMDIEF = new KIDALMMDIEF();
				if (targetImplCase_ == TargetImplOneofCase.TargetNone)
				{
					kIDALMMDIEF.MergeFrom(TargetNone);
				}
				input.ReadMessage(kIDALMMDIEF);
				TargetNone = kIDALMMDIEF;
				break;
			}
			case 58u:
			{
				BHEOKGAKGMA bHEOKGAKGMA = new BHEOKGAKGMA();
				if (targetImplCase_ == TargetImplOneofCase.TargetRuanmei)
				{
					bHEOKGAKGMA.MergeFrom(TargetRuanmei);
				}
				input.ReadMessage(bHEOKGAKGMA);
				TargetRuanmei = bHEOKGAKGMA;
				break;
			}
			case 98u:
			{
				LDHOKGLFPKF lDHOKGLFPKF = new LDHOKGLFPKF();
				if (targetImplCase_ == TargetImplOneofCase.TargetCoin)
				{
					lDHOKGLFPKF.MergeFrom(TargetCoin);
				}
				input.ReadMessage(lDHOKGLFPKF);
				TargetCoin = lDHOKGLFPKF;
				break;
			}
			case 122u:
			{
				MHPMAPGKILE mHPMAPGKILE = new MHPMAPGKILE();
				if (targetImplCase_ == TargetImplOneofCase.TargetMiracle)
				{
					mHPMAPGKILE.MergeFrom(TargetMiracle);
				}
				input.ReadMessage(mHPMAPGKILE);
				TargetMiracle = mHPMAPGKILE;
				break;
			}
			}
		}
	}
}
