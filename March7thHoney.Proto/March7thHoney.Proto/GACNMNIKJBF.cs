using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GACNMNIKJBF : IMessage<GACNMNIKJBF>, IMessage, IEquatable<GACNMNIKJBF>, IDeepCloneable<GACNMNIKJBF>, IBufferMessage
{
	private static readonly MessageParser<GACNMNIKJBF> _parser = new MessageParser<GACNMNIKJBF>(() => new GACNMNIKJBF());

	private UnknownFieldSet _unknownFields;

	public const int KMKGHJJIJCNFieldNumber = 15;

	private CBJAEJAFCKG kMKGHJJIJCN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GACNMNIKJBF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GACNMNIKJBFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBJAEJAFCKG KMKGHJJIJCN
	{
		get
		{
			return kMKGHJJIJCN_;
		}
		set
		{
			kMKGHJJIJCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GACNMNIKJBF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GACNMNIKJBF(GACNMNIKJBF other)
		: this()
	{
		kMKGHJJIJCN_ = ((other.kMKGHJJIJCN_ != null) ? other.kMKGHJJIJCN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GACNMNIKJBF Clone()
	{
		return new GACNMNIKJBF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GACNMNIKJBF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GACNMNIKJBF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KMKGHJJIJCN, other.KMKGHJJIJCN))
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
		if (kMKGHJJIJCN_ != null)
		{
			num ^= KMKGHJJIJCN.GetHashCode();
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
		if (kMKGHJJIJCN_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(KMKGHJJIJCN);
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
		if (kMKGHJJIJCN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KMKGHJJIJCN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GACNMNIKJBF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kMKGHJJIJCN_ != null)
		{
			if (kMKGHJJIJCN_ == null)
			{
				KMKGHJJIJCN = new CBJAEJAFCKG();
			}
			KMKGHJJIJCN.MergeFrom(other.KMKGHJJIJCN);
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
			if (kMKGHJJIJCN_ == null)
			{
				KMKGHJJIJCN = new CBJAEJAFCKG();
			}
			input.ReadMessage(KMKGHJJIJCN);
		}
	}
}
