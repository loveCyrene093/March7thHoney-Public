using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingUnlockGridCsReq : IMessage<ChenLingUnlockGridCsReq>, IMessage, IEquatable<ChenLingUnlockGridCsReq>, IDeepCloneable<ChenLingUnlockGridCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingUnlockGridCsReq> _parser = new MessageParser<ChenLingUnlockGridCsReq>(() => new ChenLingUnlockGridCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EFOFLGIDKKKFieldNumber = 15;

	private FDOEMKPGHFL eFOFLGIDKKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingUnlockGridCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingUnlockGridCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL EFOFLGIDKKK
	{
		get
		{
			return eFOFLGIDKKK_;
		}
		set
		{
			eFOFLGIDKKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUnlockGridCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUnlockGridCsReq(ChenLingUnlockGridCsReq other)
		: this()
	{
		eFOFLGIDKKK_ = ((other.eFOFLGIDKKK_ != null) ? other.eFOFLGIDKKK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingUnlockGridCsReq Clone()
	{
		return new ChenLingUnlockGridCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingUnlockGridCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingUnlockGridCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EFOFLGIDKKK, other.EFOFLGIDKKK))
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
		if (eFOFLGIDKKK_ != null)
		{
			num ^= EFOFLGIDKKK.GetHashCode();
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
		if (eFOFLGIDKKK_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(EFOFLGIDKKK);
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
		if (eFOFLGIDKKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFOFLGIDKKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingUnlockGridCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eFOFLGIDKKK_ != null)
		{
			if (eFOFLGIDKKK_ == null)
			{
				EFOFLGIDKKK = new FDOEMKPGHFL();
			}
			EFOFLGIDKKK.MergeFrom(other.EFOFLGIDKKK);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eFOFLGIDKKK_ == null)
			{
				EFOFLGIDKKK = new FDOEMKPGHFL();
			}
			input.ReadMessage(EFOFLGIDKKK);
		}
	}
}
