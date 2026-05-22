using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BOCNDEJFCGC : IMessage<BOCNDEJFCGC>, IMessage, IEquatable<BOCNDEJFCGC>, IDeepCloneable<BOCNDEJFCGC>, IBufferMessage
{
	private static readonly MessageParser<BOCNDEJFCGC> _parser = new MessageParser<BOCNDEJFCGC>(() => new BOCNDEJFCGC());

	private UnknownFieldSet _unknownFields;

	public const int NDIGEHJBBPKFieldNumber = 5;

	private NDCJAAOLEBA nDIGEHJBBPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BOCNDEJFCGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BOCNDEJFCGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDCJAAOLEBA NDIGEHJBBPK
	{
		get
		{
			return nDIGEHJBBPK_;
		}
		set
		{
			nDIGEHJBBPK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOCNDEJFCGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOCNDEJFCGC(BOCNDEJFCGC other)
		: this()
	{
		nDIGEHJBBPK_ = ((other.nDIGEHJBBPK_ != null) ? other.nDIGEHJBBPK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BOCNDEJFCGC Clone()
	{
		return new BOCNDEJFCGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BOCNDEJFCGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BOCNDEJFCGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NDIGEHJBBPK, other.NDIGEHJBBPK))
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
		if (nDIGEHJBBPK_ != null)
		{
			num ^= NDIGEHJBBPK.GetHashCode();
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
		if (nDIGEHJBBPK_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NDIGEHJBBPK);
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
		if (nDIGEHJBBPK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NDIGEHJBBPK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BOCNDEJFCGC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nDIGEHJBBPK_ != null)
		{
			if (nDIGEHJBBPK_ == null)
			{
				NDIGEHJBBPK = new NDCJAAOLEBA();
			}
			NDIGEHJBBPK.MergeFrom(other.NDIGEHJBBPK);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nDIGEHJBBPK_ == null)
			{
				NDIGEHJBBPK = new NDCJAAOLEBA();
			}
			input.ReadMessage(NDIGEHJBBPK);
		}
	}
}
