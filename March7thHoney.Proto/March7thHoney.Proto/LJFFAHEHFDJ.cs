using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LJFFAHEHFDJ : IMessage<LJFFAHEHFDJ>, IMessage, IEquatable<LJFFAHEHFDJ>, IDeepCloneable<LJFFAHEHFDJ>, IBufferMessage
{
	private static readonly MessageParser<LJFFAHEHFDJ> _parser = new MessageParser<LJFFAHEHFDJ>(() => new LJFFAHEHFDJ());

	private UnknownFieldSet _unknownFields;

	public const int AGNHFMGIIAOFieldNumber = 9;

	private HJKGBOKKNOP aGNHFMGIIAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LJFFAHEHFDJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LJFFAHEHFDJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJKGBOKKNOP AGNHFMGIIAO
	{
		get
		{
			return aGNHFMGIIAO_;
		}
		set
		{
			aGNHFMGIIAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJFFAHEHFDJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJFFAHEHFDJ(LJFFAHEHFDJ other)
		: this()
	{
		aGNHFMGIIAO_ = ((other.aGNHFMGIIAO_ != null) ? other.aGNHFMGIIAO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LJFFAHEHFDJ Clone()
	{
		return new LJFFAHEHFDJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LJFFAHEHFDJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LJFFAHEHFDJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AGNHFMGIIAO, other.AGNHFMGIIAO))
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
		if (aGNHFMGIIAO_ != null)
		{
			num ^= AGNHFMGIIAO.GetHashCode();
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
		if (aGNHFMGIIAO_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(AGNHFMGIIAO);
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
		if (aGNHFMGIIAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AGNHFMGIIAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LJFFAHEHFDJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aGNHFMGIIAO_ != null)
		{
			if (aGNHFMGIIAO_ == null)
			{
				AGNHFMGIIAO = new HJKGBOKKNOP();
			}
			AGNHFMGIIAO.MergeFrom(other.AGNHFMGIIAO);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aGNHFMGIIAO_ == null)
			{
				AGNHFMGIIAO = new HJKGBOKKNOP();
			}
			input.ReadMessage(AGNHFMGIIAO);
		}
	}
}
