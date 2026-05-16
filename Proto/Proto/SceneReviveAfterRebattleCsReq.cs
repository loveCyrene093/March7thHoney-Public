using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneReviveAfterRebattleCsReq : IMessage<SceneReviveAfterRebattleCsReq>, IMessage, IEquatable<SceneReviveAfterRebattleCsReq>, IDeepCloneable<SceneReviveAfterRebattleCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneReviveAfterRebattleCsReq> _parser = new MessageParser<SceneReviveAfterRebattleCsReq>(() => new SceneReviveAfterRebattleCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MGABMCBOHMKFieldNumber = 9;

	private RebattleType mGABMCBOHMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneReviveAfterRebattleCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneReviveAfterRebattleCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleType MGABMCBOHMK
	{
		get
		{
			return mGABMCBOHMK_;
		}
		set
		{
			mGABMCBOHMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneReviveAfterRebattleCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneReviveAfterRebattleCsReq(SceneReviveAfterRebattleCsReq other)
		: this()
	{
		mGABMCBOHMK_ = other.mGABMCBOHMK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneReviveAfterRebattleCsReq Clone()
	{
		return new SceneReviveAfterRebattleCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneReviveAfterRebattleCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneReviveAfterRebattleCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGABMCBOHMK != other.MGABMCBOHMK)
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			num ^= MGABMCBOHMK.GetHashCode();
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MGABMCBOHMK);
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
		if (MGABMCBOHMK != RebattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MGABMCBOHMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneReviveAfterRebattleCsReq other)
	{
		if (other != null)
		{
			if (other.MGABMCBOHMK != RebattleType.None)
			{
				MGABMCBOHMK = other.MGABMCBOHMK;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				MGABMCBOHMK = (RebattleType)input.ReadEnum();
			}
		}
	}
}
