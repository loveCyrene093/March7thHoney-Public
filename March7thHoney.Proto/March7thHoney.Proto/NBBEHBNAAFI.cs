using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBBEHBNAAFI : IMessage<NBBEHBNAAFI>, IMessage, IEquatable<NBBEHBNAAFI>, IDeepCloneable<NBBEHBNAAFI>, IBufferMessage
{
	private static readonly MessageParser<NBBEHBNAAFI> _parser = new MessageParser<NBBEHBNAAFI>(() => new NBBEHBNAAFI());

	private UnknownFieldSet _unknownFields;

	public const int BPFCEJKNCDPFieldNumber = 6;

	private AKGLAEKCFNO bPFCEJKNCDP_;

	public const int GBHJGILIJMPFieldNumber = 11;

	private MGLMEMPJELD gBHJGILIJMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBBEHBNAAFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBBEHBNAAFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGLAEKCFNO BPFCEJKNCDP
	{
		get
		{
			return bPFCEJKNCDP_;
		}
		set
		{
			bPFCEJKNCDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGLMEMPJELD GBHJGILIJMP
	{
		get
		{
			return gBHJGILIJMP_;
		}
		set
		{
			gBHJGILIJMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBEHBNAAFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBEHBNAAFI(NBBEHBNAAFI other)
		: this()
	{
		bPFCEJKNCDP_ = ((other.bPFCEJKNCDP_ != null) ? other.bPFCEJKNCDP_.Clone() : null);
		gBHJGILIJMP_ = ((other.gBHJGILIJMP_ != null) ? other.gBHJGILIJMP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBBEHBNAAFI Clone()
	{
		return new NBBEHBNAAFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBBEHBNAAFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBBEHBNAAFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BPFCEJKNCDP, other.BPFCEJKNCDP))
		{
			return false;
		}
		if (!object.Equals(GBHJGILIJMP, other.GBHJGILIJMP))
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
		if (bPFCEJKNCDP_ != null)
		{
			num ^= BPFCEJKNCDP.GetHashCode();
		}
		if (gBHJGILIJMP_ != null)
		{
			num ^= GBHJGILIJMP.GetHashCode();
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
		if (bPFCEJKNCDP_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BPFCEJKNCDP);
		}
		if (gBHJGILIJMP_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(GBHJGILIJMP);
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
		if (bPFCEJKNCDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPFCEJKNCDP);
		}
		if (gBHJGILIJMP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GBHJGILIJMP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBBEHBNAAFI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bPFCEJKNCDP_ != null)
		{
			if (bPFCEJKNCDP_ == null)
			{
				BPFCEJKNCDP = new AKGLAEKCFNO();
			}
			BPFCEJKNCDP.MergeFrom(other.BPFCEJKNCDP);
		}
		if (other.gBHJGILIJMP_ != null)
		{
			if (gBHJGILIJMP_ == null)
			{
				GBHJGILIJMP = new MGLMEMPJELD();
			}
			GBHJGILIJMP.MergeFrom(other.GBHJGILIJMP);
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
			case 50u:
				if (bPFCEJKNCDP_ == null)
				{
					BPFCEJKNCDP = new AKGLAEKCFNO();
				}
				input.ReadMessage(BPFCEJKNCDP);
				break;
			case 90u:
				if (gBHJGILIJMP_ == null)
				{
					GBHJGILIJMP = new MGLMEMPJELD();
				}
				input.ReadMessage(GBHJGILIJMP);
				break;
			}
		}
	}
}
