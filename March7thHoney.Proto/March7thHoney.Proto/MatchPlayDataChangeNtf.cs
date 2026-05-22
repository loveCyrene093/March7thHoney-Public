using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchPlayDataChangeNtf : IMessage<MatchPlayDataChangeNtf>, IMessage, IEquatable<MatchPlayDataChangeNtf>, IDeepCloneable<MatchPlayDataChangeNtf>, IBufferMessage
{
	private static readonly MessageParser<MatchPlayDataChangeNtf> _parser = new MessageParser<MatchPlayDataChangeNtf>(() => new MatchPlayDataChangeNtf());

	private UnknownFieldSet _unknownFields;

	public const int PAAGKBFNHKKFieldNumber = 10;

	private BPJDOEMBNMD pAAGKBFNHKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchPlayDataChangeNtf> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchPlayDataChangeNtfReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPJDOEMBNMD PAAGKBFNHKK
	{
		get
		{
			return pAAGKBFNHKK_;
		}
		set
		{
			pAAGKBFNHKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchPlayDataChangeNtf()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchPlayDataChangeNtf(MatchPlayDataChangeNtf other)
		: this()
	{
		pAAGKBFNHKK_ = ((other.pAAGKBFNHKK_ != null) ? other.pAAGKBFNHKK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchPlayDataChangeNtf Clone()
	{
		return new MatchPlayDataChangeNtf(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchPlayDataChangeNtf);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchPlayDataChangeNtf other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PAAGKBFNHKK, other.PAAGKBFNHKK))
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
		if (pAAGKBFNHKK_ != null)
		{
			num ^= PAAGKBFNHKK.GetHashCode();
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
		if (pAAGKBFNHKK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PAAGKBFNHKK);
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
		if (pAAGKBFNHKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PAAGKBFNHKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchPlayDataChangeNtf other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pAAGKBFNHKK_ != null)
		{
			if (pAAGKBFNHKK_ == null)
			{
				PAAGKBFNHKK = new BPJDOEMBNMD();
			}
			PAAGKBFNHKK.MergeFrom(other.PAAGKBFNHKK);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pAAGKBFNHKK_ == null)
			{
				PAAGKBFNHKK = new BPJDOEMBNMD();
			}
			input.ReadMessage(PAAGKBFNHKK);
		}
	}
}
