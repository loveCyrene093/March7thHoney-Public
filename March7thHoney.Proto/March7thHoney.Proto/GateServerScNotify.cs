using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GateServerScNotify : IMessage<GateServerScNotify>, IMessage, IEquatable<GateServerScNotify>, IDeepCloneable<GateServerScNotify>, IBufferMessage
{
	private static readonly MessageParser<GateServerScNotify> _parser = new MessageParser<GateServerScNotify>(() => new GateServerScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KGHHBLGPJJIFieldNumber = 11;

	private string kGHHBLGPJJI_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GateServerScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GateServerScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string KGHHBLGPJJI
	{
		get
		{
			return kGHHBLGPJJI_;
		}
		set
		{
			kGHHBLGPJJI_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServerScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServerScNotify(GateServerScNotify other)
		: this()
	{
		kGHHBLGPJJI_ = other.kGHHBLGPJJI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServerScNotify Clone()
	{
		return new GateServerScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GateServerScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GateServerScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KGHHBLGPJJI != other.KGHHBLGPJJI)
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
		if (KGHHBLGPJJI.Length != 0)
		{
			num ^= KGHHBLGPJJI.GetHashCode();
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
		if (KGHHBLGPJJI.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(KGHHBLGPJJI);
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
		if (KGHHBLGPJJI.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KGHHBLGPJJI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GateServerScNotify other)
	{
		if (other != null)
		{
			if (other.KGHHBLGPJJI.Length != 0)
			{
				KGHHBLGPJJI = other.KGHHBLGPJJI;
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KGHHBLGPJJI = input.ReadString();
			}
		}
	}
}
