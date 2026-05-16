using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MPAACMCJIHG : IMessage<MPAACMCJIHG>, IMessage, IEquatable<MPAACMCJIHG>, IDeepCloneable<MPAACMCJIHG>, IBufferMessage
{
	private static readonly MessageParser<MPAACMCJIHG> _parser = new MessageParser<MPAACMCJIHG>(() => new MPAACMCJIHG());

	private UnknownFieldSet _unknownFields;

	public const int IAAFEIMNEMMFieldNumber = 10;

	private KHHHFHEODED iAAFEIMNEMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MPAACMCJIHG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MPAACMCJIHGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED IAAFEIMNEMM
	{
		get
		{
			return iAAFEIMNEMM_;
		}
		set
		{
			iAAFEIMNEMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPAACMCJIHG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPAACMCJIHG(MPAACMCJIHG other)
		: this()
	{
		iAAFEIMNEMM_ = ((other.iAAFEIMNEMM_ != null) ? other.iAAFEIMNEMM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPAACMCJIHG Clone()
	{
		return new MPAACMCJIHG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MPAACMCJIHG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MPAACMCJIHG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IAAFEIMNEMM, other.IAAFEIMNEMM))
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
		if (iAAFEIMNEMM_ != null)
		{
			num ^= IAAFEIMNEMM.GetHashCode();
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
		if (iAAFEIMNEMM_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(IAAFEIMNEMM);
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
		if (iAAFEIMNEMM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAAFEIMNEMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MPAACMCJIHG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iAAFEIMNEMM_ != null)
		{
			if (iAAFEIMNEMM_ == null)
			{
				IAAFEIMNEMM = new KHHHFHEODED();
			}
			IAAFEIMNEMM.MergeFrom(other.IAAFEIMNEMM);
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
			if (iAAFEIMNEMM_ == null)
			{
				IAAFEIMNEMM = new KHHHFHEODED();
			}
			input.ReadMessage(IAAFEIMNEMM);
		}
	}
}
