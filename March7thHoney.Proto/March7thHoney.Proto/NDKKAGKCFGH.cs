using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NDKKAGKCFGH : IMessage<NDKKAGKCFGH>, IMessage, IEquatable<NDKKAGKCFGH>, IDeepCloneable<NDKKAGKCFGH>, IBufferMessage
{
	private static readonly MessageParser<NDKKAGKCFGH> _parser = new MessageParser<NDKKAGKCFGH>(() => new NDKKAGKCFGH());

	private UnknownFieldSet _unknownFields;

	public const int ONAJJGCJOHAFieldNumber = 3;

	private FEDEIOIJJJC oNAJJGCJOHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NDKKAGKCFGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NDKKAGKCFGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDEIOIJJJC ONAJJGCJOHA
	{
		get
		{
			return oNAJJGCJOHA_;
		}
		set
		{
			oNAJJGCJOHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDKKAGKCFGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDKKAGKCFGH(NDKKAGKCFGH other)
		: this()
	{
		oNAJJGCJOHA_ = ((other.oNAJJGCJOHA_ != null) ? other.oNAJJGCJOHA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDKKAGKCFGH Clone()
	{
		return new NDKKAGKCFGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NDKKAGKCFGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NDKKAGKCFGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ONAJJGCJOHA, other.ONAJJGCJOHA))
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
		if (oNAJJGCJOHA_ != null)
		{
			num ^= ONAJJGCJOHA.GetHashCode();
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
		if (oNAJJGCJOHA_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ONAJJGCJOHA);
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
		if (oNAJJGCJOHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONAJJGCJOHA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NDKKAGKCFGH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oNAJJGCJOHA_ != null)
		{
			if (oNAJJGCJOHA_ == null)
			{
				ONAJJGCJOHA = new FEDEIOIJJJC();
			}
			ONAJJGCJOHA.MergeFrom(other.ONAJJGCJOHA);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oNAJJGCJOHA_ == null)
			{
				ONAJJGCJOHA = new FEDEIOIJJJC();
			}
			input.ReadMessage(ONAJJGCJOHA);
		}
	}
}
