using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DiceCombatFinishPveStageCsReq : IMessage<DiceCombatFinishPveStageCsReq>, IMessage, IEquatable<DiceCombatFinishPveStageCsReq>, IDeepCloneable<DiceCombatFinishPveStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<DiceCombatFinishPveStageCsReq> _parser = new MessageParser<DiceCombatFinishPveStageCsReq>(() => new DiceCombatFinishPveStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int IsWinFieldNumber = 5;

	private bool isWin_;

	public const int DamageFieldNumber = 7;

	private uint damage_;

	public const int BIODAJLLINOFieldNumber = 10;

	private bool bIODAJLLINO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DiceCombatFinishPveStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DiceCombatFinishPveStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BIODAJLLINO
	{
		get
		{
			return bIODAJLLINO_;
		}
		set
		{
			bIODAJLLINO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatFinishPveStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatFinishPveStageCsReq(DiceCombatFinishPveStageCsReq other)
		: this()
	{
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		isWin_ = other.isWin_;
		damage_ = other.damage_;
		bIODAJLLINO_ = other.bIODAJLLINO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatFinishPveStageCsReq Clone()
	{
		return new DiceCombatFinishPveStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DiceCombatFinishPveStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DiceCombatFinishPveStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (Damage != other.Damage)
		{
			return false;
		}
		if (BIODAJLLINO != other.BIODAJLLINO)
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
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (Damage != 0)
		{
			num ^= Damage.GetHashCode();
		}
		if (BIODAJLLINO)
		{
			num ^= BIODAJLLINO.GetHashCode();
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
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (IsWin)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsWin);
		}
		if (Damage != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Damage);
		}
		if (BIODAJLLINO)
		{
			output.WriteRawTag(80);
			output.WriteBool(BIODAJLLINO);
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
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (Damage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Damage);
		}
		if (BIODAJLLINO)
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
	public void MergeFrom(DiceCombatFinishPveStageCsReq other)
	{
		if (other != null)
		{
			if (other.MMLKFJIAKKH != 0)
			{
				MMLKFJIAKKH = other.MMLKFJIAKKH;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.Damage != 0)
			{
				Damage = other.Damage;
			}
			if (other.BIODAJLLINO)
			{
				BIODAJLLINO = other.BIODAJLLINO;
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
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 40u:
				IsWin = input.ReadBool();
				break;
			case 56u:
				Damage = input.ReadUInt32();
				break;
			case 80u:
				BIODAJLLINO = input.ReadBool();
				break;
			}
		}
	}
}
