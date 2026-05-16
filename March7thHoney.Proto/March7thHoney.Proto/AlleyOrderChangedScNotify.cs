using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyOrderChangedScNotify : IMessage<AlleyOrderChangedScNotify>, IMessage, IEquatable<AlleyOrderChangedScNotify>, IDeepCloneable<AlleyOrderChangedScNotify>, IBufferMessage
{
	private static readonly MessageParser<AlleyOrderChangedScNotify> _parser = new MessageParser<AlleyOrderChangedScNotify>(() => new AlleyOrderChangedScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FCLMOOKJGPNFieldNumber = 5;

	private PLIEEDKHGNN fCLMOOKJGPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyOrderChangedScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyOrderChangedScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIEEDKHGNN FCLMOOKJGPN
	{
		get
		{
			return fCLMOOKJGPN_;
		}
		set
		{
			fCLMOOKJGPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyOrderChangedScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyOrderChangedScNotify(AlleyOrderChangedScNotify other)
		: this()
	{
		fCLMOOKJGPN_ = ((other.fCLMOOKJGPN_ != null) ? other.fCLMOOKJGPN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyOrderChangedScNotify Clone()
	{
		return new AlleyOrderChangedScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyOrderChangedScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyOrderChangedScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FCLMOOKJGPN, other.FCLMOOKJGPN))
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
		if (fCLMOOKJGPN_ != null)
		{
			num ^= FCLMOOKJGPN.GetHashCode();
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
		if (fCLMOOKJGPN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FCLMOOKJGPN);
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
		if (fCLMOOKJGPN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCLMOOKJGPN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyOrderChangedScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fCLMOOKJGPN_ != null)
		{
			if (fCLMOOKJGPN_ == null)
			{
				FCLMOOKJGPN = new PLIEEDKHGNN();
			}
			FCLMOOKJGPN.MergeFrom(other.FCLMOOKJGPN);
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
			if (fCLMOOKJGPN_ == null)
			{
				FCLMOOKJGPN = new PLIEEDKHGNN();
			}
			input.ReadMessage(FCLMOOKJGPN);
		}
	}
}
