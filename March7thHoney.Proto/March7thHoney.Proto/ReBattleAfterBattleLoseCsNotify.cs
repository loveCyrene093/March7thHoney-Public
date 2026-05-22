using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReBattleAfterBattleLoseCsNotify : IMessage<ReBattleAfterBattleLoseCsNotify>, IMessage, IEquatable<ReBattleAfterBattleLoseCsNotify>, IDeepCloneable<ReBattleAfterBattleLoseCsNotify>, IBufferMessage
{
	private static readonly MessageParser<ReBattleAfterBattleLoseCsNotify> _parser = new MessageParser<ReBattleAfterBattleLoseCsNotify>(() => new ReBattleAfterBattleLoseCsNotify());

	private UnknownFieldSet _unknownFields;

	public const int FDBGOJCKLBHFieldNumber = 5;

	private bool fDBGOJCKLBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReBattleAfterBattleLoseCsNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ReBattleAfterBattleLoseCsNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDBGOJCKLBH
	{
		get
		{
			return fDBGOJCKLBH_;
		}
		set
		{
			fDBGOJCKLBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReBattleAfterBattleLoseCsNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReBattleAfterBattleLoseCsNotify(ReBattleAfterBattleLoseCsNotify other)
		: this()
	{
		fDBGOJCKLBH_ = other.fDBGOJCKLBH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReBattleAfterBattleLoseCsNotify Clone()
	{
		return new ReBattleAfterBattleLoseCsNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ReBattleAfterBattleLoseCsNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReBattleAfterBattleLoseCsNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FDBGOJCKLBH != other.FDBGOJCKLBH)
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
		if (FDBGOJCKLBH)
		{
			num ^= FDBGOJCKLBH.GetHashCode();
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
		if (FDBGOJCKLBH)
		{
			output.WriteRawTag(40);
			output.WriteBool(FDBGOJCKLBH);
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
		if (FDBGOJCKLBH)
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
	public void MergeFrom(ReBattleAfterBattleLoseCsNotify other)
	{
		if (other != null)
		{
			if (other.FDBGOJCKLBH)
			{
				FDBGOJCKLBH = other.FDBGOJCKLBH;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FDBGOJCKLBH = input.ReadBool();
			}
		}
	}
}
