using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHILIFOOIGH : IMessage<KHILIFOOIGH>, IMessage, IEquatable<KHILIFOOIGH>, IDeepCloneable<KHILIFOOIGH>, IBufferMessage
{
	private static readonly MessageParser<KHILIFOOIGH> _parser = new MessageParser<KHILIFOOIGH>(() => new KHILIFOOIGH());

	private UnknownFieldSet _unknownFields;

	public const int JFAEHLOFDBCFieldNumber = 13;

	private JEEMHKBFMFG jFAEHLOFDBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHILIFOOIGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHILIFOOIGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEMHKBFMFG JFAEHLOFDBC
	{
		get
		{
			return jFAEHLOFDBC_;
		}
		set
		{
			jFAEHLOFDBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHILIFOOIGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHILIFOOIGH(KHILIFOOIGH other)
		: this()
	{
		jFAEHLOFDBC_ = ((other.jFAEHLOFDBC_ != null) ? other.jFAEHLOFDBC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHILIFOOIGH Clone()
	{
		return new KHILIFOOIGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHILIFOOIGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHILIFOOIGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JFAEHLOFDBC, other.JFAEHLOFDBC))
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
		if (jFAEHLOFDBC_ != null)
		{
			num ^= JFAEHLOFDBC.GetHashCode();
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
		if (jFAEHLOFDBC_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(JFAEHLOFDBC);
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
		if (jFAEHLOFDBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JFAEHLOFDBC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KHILIFOOIGH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jFAEHLOFDBC_ != null)
		{
			if (jFAEHLOFDBC_ == null)
			{
				JFAEHLOFDBC = new JEEMHKBFMFG();
			}
			JFAEHLOFDBC.MergeFrom(other.JFAEHLOFDBC);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (jFAEHLOFDBC_ == null)
			{
				JFAEHLOFDBC = new JEEMHKBFMFG();
			}
			input.ReadMessage(JFAEHLOFDBC);
		}
	}
}
